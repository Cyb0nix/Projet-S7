

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI;

public class Pizza : Items
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [ForeignKey("OrderId")]
    public int Order { get; set; }
    public string Size { get; set; }

    public string Type { get; set; }

    public int Price { get; set; }
    
    public string Status { get; set; }

    public Pizza(string name, string size, string type, int price, int quantity, string status)
    {
        this.Name = name;
        this.Size = size;
        this.Type = type;
        this.Price = price;
        this.Quantity = quantity;
        this.Status = status;
    }

}

