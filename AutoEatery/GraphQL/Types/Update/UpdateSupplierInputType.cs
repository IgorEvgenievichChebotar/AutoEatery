using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types.Update;

public sealed class UpdateSupplierInputType : InputObjectGraphType<Supplier>
{
    public UpdateSupplierInputType()
    {
        Field<IntGraphType>("id");
        Field(c => c.OrganizationName);
        Field<ListGraphType<Create.CreateIngredientInputType>>("ingredients");
    }
}