using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types.Create;

public sealed class CreateSupplierInputType : InputObjectGraphType<Supplier>
{
    public CreateSupplierInputType()
    {
        Field(c => c.OrganizationName);
        Field<ListGraphType<CreateIngredientInputType>>("ingredients");
    }
}