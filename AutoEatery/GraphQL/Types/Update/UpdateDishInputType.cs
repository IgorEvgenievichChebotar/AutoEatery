using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types.Update;

public sealed class UpdateDishInputType : InputObjectGraphType<Dish>
{
    public UpdateDishInputType()
    {
        Field<IntGraphType>("id");
        Field(d => d.Price);
        Field(d => d.Calories);
        Field(d => d.CookedAt);
    }
}