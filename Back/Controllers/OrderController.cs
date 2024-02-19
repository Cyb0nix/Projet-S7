using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PizzaAPI.utils;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{

    private readonly ILogger<OrderController> _logger;
    private static dbContext _dbContext;

    public OrderController(ILogger<OrderController> logger, dbContext dbContext)
    {
        _dbContext = dbContext;
        _logger = logger;
    }


    [HttpGet("All")]
    public IEnumerable<Order> GetAllCustomerOrders()
    {
        return _dbContext.Orders.ToList();
    }

    [HttpGet("{telephone}")]
    public Order GetOrder(string telephone)
    {
        Order? order;
        try
        {
            order =  _dbContext.Orders.Find(telephone);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return order;
    }


    [HttpPost]
    public void CreateOrder([FromBody] Order order, [FromQuery]int clerkId)
    {   
        _dbContext.Orders.Add(order);
        var customer = _dbContext.Customers.Find(order.Customer);
        if (customer.OrderCount == 0)
        {
            customer.AccountsReceivable += order.TotalPrice;
        }
        else
        {
            customer.AccountsReceivable = (customer.AccountsReceivable * order.TotalPrice + order.TotalPrice) / customer.OrderCount + 1; 
        }
       
        _dbContext.Clerks.Find(clerkId).OrderCount++;
        
        _dbContext.SaveChanges();
        
        try
        {
            foreach (var item in order.Pizzas)
            {
                item.OrderNumber = order.OrderNumber;
                item.Status = "Pending";
                SendMessage(item, null, null, "Pizza", "Pizza");
            }

            if (order.Drinks != null)
                foreach (var item in order.Drinks)
                {
                    item.OrderNumber = order.OrderNumber;
                    SendMessage(null, item, null, "Drink", "Drink");
                }

            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    [HttpPut("cancel/{id}")]
    public void CancelOrder(int id)
    {
        var order = _dbContext.Orders.Find(id);
        order.Status = "Cancelled";
        _dbContext.SaveChanges();
    }
    
    
    [HttpPut("prepare/{id}")]
    public void PrepareOrder(int id)
    {
        var order = _dbContext.Orders.Find(id);
        order.Status = "Ready";
        _dbContext.SaveChanges();
        
        
        order.Pizzas = GetPizza(order.OrderNumber.ToString());
        order.Drinks = getDrinks(order.OrderNumber.ToString());
        
        //send order to queue
        SendMessage(null, null, order, "OrderReady", "OrderReady");
        

    }
    
    [HttpPut("deliver/{id}")]
    public void DeliverOrder(int id, [FromQuery]int delivererId)
    {
        var order = _dbContext.Orders.Find(id);
        order.Status = "Closed";
        _dbContext.Deliverers.Find(delivererId).OrderCount++;
        _dbContext.SaveChanges();
    }
    
    [HttpPut("pay/{id}")]
    public void PayOrder(int id)
    {
        var order = _dbContext.Orders.Find(id);
        order.Status = "Paid";
        _dbContext.SaveChanges();
    }
    
    [HttpPut("lost/{id}")]
    public void LostOrder(int id)
    {
        var order = _dbContext.Orders.Find(id);
        order.Status = "Lost";
        _dbContext.SaveChanges();
    }
    
    [HttpGet("price/{id}")]
    public int GetOrderPrice(int id)
    {
        var order = _dbContext.Orders.Find(id);
        return order.TotalPrice;
    }
    

    private static void SendMessage(Pizza? pizza, Drink? drink, Order? order, string exchange, string routingKey)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {

            channel.ExchangeDeclare(exchange: exchange,
                type: "direct");
            channel.QueueDeclare(queue: exchange,
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            channel.QueueBind(queue: exchange,
                exchange: exchange,
                routingKey: routingKey);

            //convert message to byte array
            var message = "";
            if (pizza != null)
            {
                message = JsonSerializer.Serialize(pizza);
            }
            if (drink != null)
            {
                message = JsonSerializer.Serialize(drink);
            }
            if (order != null)
            {
                message = JsonSerializer.Serialize(order);
            }
            var body = Encoding.UTF8.GetBytes(message);

            // Publish the message
            channel.BasicPublish(exchange: exchange,
                routingKey: routingKey,
                basicProperties: null,
                body: body);
        }




    }
    
    private static List<Pizza> GetPizza(string id)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
 
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.ExchangeDeclare(exchange: "PizzaReady",
                type: "direct");

            channel.QueueDeclare(queue: "PizzaReady",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            channel.QueueBind(queue: "PizzaReady",
                exchange: "PizzaReady",
                routingKey: id);
            var consumer = new EventingBasicConsumer(channel);
            List<Pizza> pizza = new List<Pizza>();
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body.ToArray());
                pizza.Add(JsonSerializer.Deserialize<Pizza>(message));
            };
            channel.BasicConsume("Pizza", true, consumer);
            return pizza;
        }
    }
    
    private static List<Drink> getDrinks(string id)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
 
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.ExchangeDeclare(exchange: "Drink",
                type: "direct");

            channel.QueueDeclare(queue: "Drink",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            channel.QueueBind(queue: "Drink",
                exchange: "Drink",
                routingKey: id);
            var consumer = new EventingBasicConsumer(channel);
            List<Drink> drinks = new List<Drink>();
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body.ToArray());
                drinks.Add(JsonSerializer.Deserialize<Drink>(message));
            };
            channel.BasicConsume("Drink", true, consumer);
            return drinks;
        }
    }
    
    
}