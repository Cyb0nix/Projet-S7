using System.ComponentModel.DataAnnotations;

namespace PizzaAPI;

public class Clerk : Workforce
{
    [Key]
    public int ID { get; set; }
    public string type { get; set; }
    
    public int OrderCount { get; set; }
    
    public Clerk( string surname, string firstname)
    {
        Surname = surname;
        Firstname = firstname;
        type = "Clerk";
        OrderCount = 0;
    }
}