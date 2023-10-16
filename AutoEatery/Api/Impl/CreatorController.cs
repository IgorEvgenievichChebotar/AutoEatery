using AutoEatery.Data;
using AutoEatery.Data.Models;
using AutoEatery.Messages;
using AutoMapper;
using EasyNetQ;
using Microsoft.AspNetCore.Mvc;
using static AutoEatery.Api.ApiParams;

namespace AutoEatery.Api.Impl;

[ApiController]
public class CreatorController : ControllerBase, ICreatorApi
{
    private readonly IBus _bus;
    private readonly EateryDbContext _db;
    private readonly IMapper _mapper;

    public CreatorController(EateryDbContext db, IBus bus, IMapper mapper)
    {
        _db = db;
        _bus = bus;
        _mapper = mapper;
    }

    [HttpPost(API_SUPPLIERS)]
    public async Task<IActionResult> AddSupplier([FromBody] Supplier supplier)
    {
        return await Add(supplier);
    }

    [HttpPost(API_ORDERS)]
    public async Task<IActionResult> AddOrder([FromBody] Order order)
    {
        await _bus.PubSub.PublishAsync(_mapper.Map<NewOrderMessage>(order));
        return await Add(order);
    }

    [HttpPost(API_DISHES)]
    public async Task<IActionResult> AddDishes([FromBody] Dish dish)
    {
        return await Add(dish);
    }

    [HttpPost(API_INGREDIENTS)]
    public async Task<IActionResult> AddIngredients([FromBody] Ingredient ingredient)
    {
        return await Add(ingredient);
    }

    private async Task<IActionResult> Add<E>(E entity) where E : BaseEntity
    {
        await _db.Set<E>().AddAsync(entity);
        return Ok();
    }
}