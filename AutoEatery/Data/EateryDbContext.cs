using AutoEatery.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoEatery.Data;

public class EateryDbContext : DbContext
{
    public EateryDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
}