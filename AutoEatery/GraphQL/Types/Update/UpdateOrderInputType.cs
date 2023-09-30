using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types.Update;

public sealed class UpdateOrderInputType : InputObjectGraphType<Order>
{
    public UpdateOrderInputType()
    {
        Field<IntGraphType>("id");
        Field<ListGraphType<Create.CreateDishInputType>>("dishes");
    }
}