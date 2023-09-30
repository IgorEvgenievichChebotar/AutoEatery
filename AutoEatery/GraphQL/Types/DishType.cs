using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types;

public sealed class DishType : ObjectGraphType<Dish>
{
    public DishType()
    {
        Field(c => c.Id);
        Field(c => c.Calories);
        Field(c => c.Price);
        Field(c => c.CookedAt);
    }
}