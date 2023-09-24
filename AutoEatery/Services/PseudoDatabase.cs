using AutoEatery.Models;
using AutoEatery.Util;

namespace AutoEatery.Services;

public interface IPseudoDatabase
{
    List<Order> Orders { get; set; }
    List<Dish> Dishes { get; set; }
    List<Supplier> Suppliers { get; set; }
    List<Ingredient> Ingredients { get; set; }
    void UpdateSupplier(Supplier supplier);
    void DeleteSupplier(int id);
}

public class PseudoDatabase : IPseudoDatabase
{
    private static readonly Order[] _orders = Enumerable.Range(1, 100)
        .Select(i => new Order { Id = i })
        .ToArray();

    private static readonly Dish[] _dishes = Enumerable.Range(1, 100)
        .Select(i => new Dish
        {
            Id = i,
            Price = new Random().NextDecimal(100, 1000),
            CookedAt = DateTime.Now.Subtract(TimeSpan.FromHours(new Random().NextDouble(1, 24))),
            Calories = new Random().Next(400, 2000)
        })
        .ToArray();

    private static readonly Ingredient[] _ingredients =
    {
        new() { Id = 1, Name = "Огурец" },
        new() { Id = 2, Name = "Помидор" },
        new() { Id = 3, Name = "Говядина" },
    };

    private static readonly Supplier[] _suppliers =
    {
        new()
        {
            Id = 1,
            OrganizationName = "ООО 'Белорусский овощ'",
            SuppliedIngredients = new List<Ingredient> { _ingredients[0] }
        },
        new()
        {
            Id = 2,
            OrganizationName = "ООО 'Дачная грядка'",
            SuppliedIngredients = new List<Ingredient> { _ingredients[1] }
        },
        new()
        {
            Id = 3,
            OrganizationName = "ИП 'Васильев Иван Игоревич'",
            SuppliedIngredients = new List<Ingredient> { _ingredients[2] }
        },
    };

    public List<Order> Orders { get; set; } = _orders.ToList();
    public List<Dish> Dishes { get; set; } = _dishes.ToList();
    public List<Supplier> Suppliers { get; set; } = _suppliers.ToList();
    public List<Ingredient> Ingredients { get; set; } = _ingredients.ToList();

    public void UpdateSupplier(Supplier supplier)
    {
        for (var i = 0; i < Suppliers.Count; i++)
        {
            if (Suppliers[i].Id != supplier.Id) continue;
            Suppliers[i] = supplier;
            return;
        }
    }

    public void DeleteSupplier(int id)
    {
        Suppliers.RemoveAll(s => s.Id == id);
    }
}