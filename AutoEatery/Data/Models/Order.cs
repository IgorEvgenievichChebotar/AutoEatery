namespace AutoEatery.Data.Models;

public class Order : BaseEntity
{
    public virtual ICollection<Dish>? Dishes { get; set; }

    public decimal TotalCost => Dishes?.Sum(d => d.Price) ?? 0;
}