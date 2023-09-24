namespace AutoEatery.Models;

public class Dish : BaseEntity
{
    public decimal Price { get; set; }
    public int Calories { get; set; }
    public DateTime CookedAt { get; set; }
}