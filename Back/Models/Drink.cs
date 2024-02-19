using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI;

public class Drink : Items
{
    public string Type { get; set; }


    public Drink(int price, string type)
    {
        Price = price;
        Type = type;
    }
}