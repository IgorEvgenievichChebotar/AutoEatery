using AutoEatery.Data;
using AutoEatery.GraphQL.Types;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace AutoEatery.GraphQL.Queries;

public sealed class EateryQuery : ObjectGraphType
{
    public EateryQuery(EateryDbContext dbContext)
    {
        Field<ListGraphType<DishType>>("dishes")
            .ResolveAsync(async _ => await dbContext.Dishes.ToListAsync());
        Field<ListGraphType<IngredientType>>("ingredients")
            .ResolveAsync(async _ => await dbContext.Ingredients.ToListAsync());
        Field<ListGraphType<OrderType>>("orders")
            .ResolveAsync(async _ => await dbContext.Orders
                .Include(o => o.Dishes)
                .ToListAsync());
        Field<ListGraphType<SupplierType>>("suppliers")
            .ResolveAsync(async _ => await dbContext.Suppliers
                .Include(s => s.SuppliedIngredients)
                .ToListAsync());
    }
}