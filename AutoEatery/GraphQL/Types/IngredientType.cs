using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types;

public sealed class IngredientType : ObjectGraphType<Ingredient>
{
    public IngredientType()
    {
        Field(c => c.Id);
        Field(c => c.Name);
    }
}