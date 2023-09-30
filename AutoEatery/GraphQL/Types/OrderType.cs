using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types;

public sealed class OrderType : ObjectGraphType<Order>
{
    public OrderType()
    {
        Field(c => c.Id);
        Field(c => c.TotalCost);
        Field<ListGraphType<DishType>>("dishes");
    }
}