using AutoEatery.Data.Models;
using AutoEatery.Messages;
using AutoMapper;

namespace AutoEatery.MapperProfiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, NewOrderMessage>().ReverseMap();
        CreateMap<Dish, NewDishMessage>().ReverseMap();
    }
}