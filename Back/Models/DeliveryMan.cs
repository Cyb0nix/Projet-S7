using System.ComponentModel.DataAnnotations;

namespace PizzaAPI;

public class DeliveryMan : Workforce
{   
    [Key]
    public int ID { get; set; }
    public string type { get; set; }
    
    public int OrderCount { get; set; }
    
    public DeliveryMan(string surname, string firstname)
    {
        Surname = surname;
        Firstname = firstname;
        type = "Deliverer";
        OrderCount = 0;
    }
    
}