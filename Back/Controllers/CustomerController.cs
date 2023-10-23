using Microsoft.AspNetCore.Mvc;
using PizzaAPI.utils;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private dbContext _dbContext;

    private readonly ILogger<CustomerController> _logger;

    public CustomerController(ILogger<CustomerController> logger, dbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }
    
    
    [HttpGet("All")]
    public IEnumerable<Customer> Get()
    {
        return _dbContext.Customers.ToList();
    }
    
    [HttpGet("{telephone}")]
    public Customer Get(string telephone)
    {
        return _dbContext.Customers.Find(telephone);
    }
    
    [HttpPost]
    public void Post([FromBody] Customer customer)
    {
        _dbContext.Customers.Add(customer);
        _dbContext.SaveChanges();
    }
    
    
    
}