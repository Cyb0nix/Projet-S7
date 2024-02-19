using Microsoft.AspNetCore.Mvc;
using PizzaAPI.utils;


namespace PizzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private static dbContext _dbContext;

    public CustomerController(ILogger<CustomerController> logger, dbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet("All")]
    public IEnumerable<Customer> GetAllCustomer()
    {
        return _dbContext.Customers.ToList();
    }
    
    [HttpGet("{telephone}")]
    public Customer GetCustomer(string telephone)
    {
        Customer? customer;
        try
        {
            customer = _dbContext.Customers.Find(telephone);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return customer;
    }
    
    
    [HttpGet("byName")]
    public IEnumerable<Customer> GetCustomerByName()
    {
        return _dbContext.Customers.OrderBy(c => c.Surname).ToList();
    }
    

    [HttpGet("best")]
    public Customer GetBestCustomer()
    {
        return _dbContext.Customers.OrderByDescending(c => c.AccountsReceivable).First();
    }
    
    
    
    [HttpPost] 
    public void CreateCustomer([FromBody] Customer customer)
    {
        try
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    
    
    
}