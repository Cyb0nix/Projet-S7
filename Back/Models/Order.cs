using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI;

public class Order
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderNumber { get; set; }
    
    [ForeignKey("telephone")]
    public string Customer { get; set; }
    
    public TimeOnly Time { get; set; }
    
    public DateOnly Date { get; set; }
    
    public string CustomerName { get; set; }
    
    [NotMapped]
    public List<Pizza> Pizzas { get; set; }
    
    [NotMapped]
    public List<Drink>? Drinks { get; set; }
    
    public string Status { get; set; }
    
    public int TotalPrice { get; set; }

    public Order(int orderNumber, DateOnly date, string customerName, string status, string customer)
    {
        Pizzas = new List<Pizza>();
        Drinks = new List<Drink>();
        Customer = customer;
        OrderNumber = orderNumber;
        Time = TimeOnly.FromDateTime(DateTime.Now);
        Date = date;
        CustomerName = customerName;
        Status = status;
        Console.WriteLine(Pizzas);
        foreach (var items in this.Pizzas)
        {
            this.TotalPrice += items.Price;
        }
        if (Drinks != null)
        {
            foreach (var items in Drinks)
            {
                this.TotalPrice += items.Price;
            }
        }
    }
    
    
}