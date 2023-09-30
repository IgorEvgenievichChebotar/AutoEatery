using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types.Update;

public sealed class UpdateIngredientInputType : InputObjectGraphType<Ingredient>
{
    public UpdateIngredientInputType()
    {
        Field<IntGraphType>("id");
        Field(c => c.Name);
    }
}