using AutoEatery.Data.Models;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Types.Create;

public sealed class CreateOrderInputType : InputObjectGraphType<Order>
{
    public CreateOrderInputType()
    {
        Field<ListGraphType<CreateDishInputType>>("dishes");
    }
}