using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types;

public sealed class SupplierType : ObjectGraphType<Supplier>
{
    public SupplierType()
    {
        Field(c => c.Id);
        Field(c => c.OrganizationName);
        Field<ListGraphType<IngredientType>>("ingredients");
    }
}