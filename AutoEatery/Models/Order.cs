namespace AutoEatery.Models;

public class Order : BaseEntity
{
    public List<Dish> Dishes { get; set; } = new();

    public decimal TotalCost
    {
        get => Dishes.Sum(d => d.Price);
        set => throw new InvalidOperationException("TotalCost cannot be directly set, it's auto calculated");
    }
}