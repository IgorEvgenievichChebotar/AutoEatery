namespace AutoEatery.Data.Models;

public class Supplier : BaseEntity
{
    public virtual ICollection<Ingredient>? SuppliedIngredients { get; set; }
    public string? OrganizationName { get; set; }
}