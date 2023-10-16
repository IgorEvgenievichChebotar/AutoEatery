namespace AutoEatery.Messages;

public class NewOrderMessage
{
    public List<NewDishMessage> Dishes { get; set; } = new();
}