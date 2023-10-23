using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI;

public class Order
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderNumber { get; set; }
    
    [ForeignKey("telephone")]
    public int Customer { get; set; }
    
    public TimeOnly Time { get; set; }
    
    public DateOnly Date { get; set; }
    
    public string CustomerName { get; set; }
    
    [NotMapped]
    public List<Items> Items { get; set; }
    
    public string Status { get; set; }
    
    public int TotalPrice { get; set; }

    public Order(int orderNumber, TimeOnly time, DateOnly date, string customerName, string status)
    {
        OrderNumber = orderNumber;
        Time = time;
        Date = date;
        CustomerName = customerName;
        Status = status;
    }
    
    
}