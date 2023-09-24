namespace AutoEatery.Data.Models;

public class Supplier : BaseEntity
{
    public List<Ingredient> SuppliedIngredients { get; set; } = new();
    public string? OrganizationName { get; set; }
}