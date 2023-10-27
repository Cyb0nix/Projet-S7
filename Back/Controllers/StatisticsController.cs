using Microsoft.AspNetCore.Mvc;
using PizzaAPI.utils;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class StatisticsController: ControllerBase
{
    private readonly dbContext _dbContext;

    public StatisticsController(dbContext context)
    {
        _dbContext = context;
    }
    
    [HttpGet("ordersAverage")]
    public int GetAverageOrderPrice()
    {
        var orders = _dbContext.Orders.ToList();
        var totalPrice = 0;
        foreach (var order in orders)
        {
            totalPrice += order.TotalPrice;
        }

        return totalPrice / orders.Count;
    }
    
    [HttpGet("accountsReceivable")]
    public int GetAverageAccountsReceivable()
    {
        var customers = _dbContext.Customers.ToList();
        var totalAccountsReceivable = 0;
        foreach (var customer in customers)
        {
            totalAccountsReceivable += customer.AccountsReceivable;
        }

        return totalAccountsReceivable / customers.Count;
    }
    
    [HttpGet("clerkOrders")]
    public Dictionary<string, int> GetClerkOrders()
    {
        var clerks = _dbContext.Clerks.ToList();
        var clerkOrders = new Dictionary<string, int>();
        foreach (var clerk in clerks)
        {
            clerkOrders.Add(clerk.Surname, clerk.OrderCount);
        }

        return clerkOrders;
    }
    
    [HttpGet("delivererOrders")]
    public Dictionary<string, int> GetDelivererOrders()
    {
        var deliverers = _dbContext.Deliverers.ToList();
        var delivererOrders = new Dictionary<string, int>();
        foreach (var deliverer in deliverers)
        {
            delivererOrders.Add(deliverer.Surname, deliverer.OrderCount);
        }

        return delivererOrders;
    }
    
    [HttpGet("ordersByTime")]
    public Dictionary<string, int> GetOrdersByTime()
    {
        var orders = _dbContext.Orders.ToList();
        var ordersByTime = new Dictionary<string, int>();
        foreach (var order in orders)
        {
            if (ordersByTime.ContainsKey(order.Time.ToString()))
            {
                ordersByTime[order.Time.ToString()]++;
            }
            else
            {
                ordersByTime.Add(order.Time.ToString(), 1);
            }
        }

        return ordersByTime;
    }
    
    
}