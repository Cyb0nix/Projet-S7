

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI;

public class Pizza : Items
{
    public string Size { get; set; }

    public string Type { get; set; }
    
    public string Status { get; set; }

    public Pizza(string size, string type, string status)
    {
        this.Size = size;
        this.Type = type;

        Price = size switch
        {
            "Small" => 5,
            "Medium" => 10,
            "Large" => 15,
            _ => Price
        };
        this.Status = status;
    }

}

