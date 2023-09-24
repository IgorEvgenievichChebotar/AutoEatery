using AutoEatery.Data;
using AutoEatery.Data.Models;
using Microsoft.AspNetCore.Mvc;
using static AutoEatery.Api.ApiParams;

namespace AutoEatery.Api.Impl;

[ApiController]
public class CreatorController : ControllerBase, ICreatorApi
{
    private readonly EateryDbContext _db;

    public CreatorController(EateryDbContext db)
    {
        _db = db;
    }

    [HttpPost(API_SUPPLIERS)]
    public IActionResult AddSupplier([FromBody] Supplier supplier)
    {
        return Add(supplier);
    }

    [HttpPost(API_ORDERS)]
    public IActionResult AddOrder([FromBody] Order order)
    {
        return Add(order);
    }

    [HttpPost(API_DISHES)]
    public IActionResult AddDishes([FromBody] Dish dish)
    {
        return Add(dish);
    }

    [HttpPost(API_INGREDIENTS)]
    public IActionResult AddIngredients([FromBody] Ingredient ingredient)
    {
        return Add(ingredient);
    }

    private IActionResult Add<E>(E entity) where E : BaseEntity
    {
        _db.Set<E>().Add(entity);
        return Ok();
    }
}