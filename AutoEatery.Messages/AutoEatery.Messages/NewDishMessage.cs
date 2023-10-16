namespace AutoEatery.Messages;

public class NewDishMessage
{
    public decimal Price { get; set; }
    public int Calories { get; set; }
    public DateTime CookedAt { get; set; }
}