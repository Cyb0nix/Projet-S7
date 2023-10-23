using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace PizzaAPI;

public class Customer
{
    public string Surname { get; set; }
    
    public string Firstname { get; set; }
    
    public string Address { get; set; }
    
    [Key]
    public string Telephone { get; set; }
    
    public DateOnly FirstOrderDate { get; set; }
    
    public int OrderCount { get; set; }
    
    public Customer(string surname, string firstname, string address, string telephone)
    {
        this.Surname = surname;
        this.Firstname = firstname;
        this.Address = address;
        this.Telephone = telephone;
        FirstOrderDate = DateOnly.FromDateTime(DateTime.Now);
        OrderCount = 0;
    }
    
}