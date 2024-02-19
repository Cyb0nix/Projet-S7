using Microsoft.AspNetCore.Mvc;
using PizzaAPI.utils;
using System;
using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PizzaController : ControllerBase
{

    private readonly ILogger<PizzaController> _logger;

    public PizzaController(ILogger<PizzaController> logger)
    {
        _logger = logger;
       
    }
    
    [HttpGet]
    public List<Pizza> GetPizza()
    {
        return MessageReceiver();
    }
    
    [HttpPost("cook")]
    public void CookPizza([FromBody] Pizza pizza)
    {
        pizza.Status = "Ready";
        SendMessage(pizza, null, "PizzaReady", pizza.OrderNumber.ToString());
    }
    private static List<Pizza> MessageReceiver()
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
 
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.ExchangeDeclare(exchange: "Pizza",
                type: "direct");

            channel.QueueDeclare(queue: "Pizza",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            channel.QueueBind(queue: "Pizza",
                exchange: "Pizza",
                routingKey: "Pizza");
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
    
    private static void SendMessage(Pizza? pizza, Drink? drink, string exchange, string routingKey)
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
            var body = Encoding.UTF8.GetBytes(message);

            // Publish the message
            channel.BasicPublish(exchange: exchange,
                routingKey: routingKey,
                basicProperties: null,
                body: body);
        }




    }
    
    
    
    
}