using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types.Create;

public sealed class CreateDishInputType : InputObjectGraphType<Dish>
{
    public CreateDishInputType()
    {
        Field(d => d.Price);
        Field(d => d.Calories);
        Field(d => d.CookedAt);
    }
}