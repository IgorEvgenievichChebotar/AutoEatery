using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types.Create;

public sealed class CreateIngredientInputType : InputObjectGraphType<Ingredient>
{
    public CreateIngredientInputType()
    {
        Field(c => c.Name);
    }
}