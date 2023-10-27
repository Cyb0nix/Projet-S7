using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaAPI.utils;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DeliveryManController: ControllerBase
{
    private readonly dbContext _context;

    public DeliveryManController(dbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<DeliveryMan>>> GetDeliverers()
    {
        return await _context.Deliverers.ToListAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<DeliveryMan>> GetDeliverer(int id)
    {
        var deliverer = await _context.Deliverers.FindAsync(id);

        if (deliverer == null)
        {
            return NotFound();
        }

        return deliverer;
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDeliverer(int id, DeliveryMan deliveryMan)
    {
        if (id != deliveryMan.ID)
        {
            return BadRequest();
        }

        _context.Entry(deliveryMan).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DelivererExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }
    
    [HttpPost]
    public async Task<ActionResult<DeliveryMan>> PostDeliverer(DeliveryMan deliveryMan)
    {
        _context.Deliverers.Add(deliveryMan);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDeliverer", new { id = deliveryMan.ID }, deliveryMan);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDeliverer(int id)
    {
        var deliverer = await _context.Deliverers.FindAsync(id);
        if (deliverer == null)
        {
            return NotFound();
        }

        _context.Deliverers.Remove(deliverer);

        await _context.SaveChangesAsync();

        return NoContent();
    }
    
    [HttpGet("deliveries")]
    public List<Order> GetDeliveries()
    {
        return getDelevries();
    }
    
    
    
    private bool DelivererExists(int id)
    {
        return _context.Deliverers.Any(e => e.ID == id);
    }
    
    private static List<Order> getDelevries()
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
 
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.ExchangeDeclare(exchange: "OrderReady",
                type: "direct");

            channel.QueueDeclare(queue: "OrderReady",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            channel.QueueBind(queue: "OrderReady",
                exchange: "OrderReady",
                routingKey: "OrderReady");
            var consumer = new EventingBasicConsumer(channel);
            List<Order> orders = new List<Order>();
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body.ToArray());
                orders.Add(JsonSerializer.Deserialize<Order>(message));
            };
            channel.BasicConsume("Drink", true, consumer);
            return orders;
        }
    }

}