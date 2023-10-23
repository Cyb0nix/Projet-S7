using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI;

public class Drink : Items
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [ForeignKey("OrderId")]
    public int Order { get; set; }
    public int Price { get; set; }
    
    public string Type { get; set; }


    public Drink(int price, string type)
    {
        Price = price;
        Type = type;
    }
}