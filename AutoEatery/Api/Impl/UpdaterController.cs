using AutoEatery.Data;
using AutoEatery.Data.Models;
using Microsoft.AspNetCore.Mvc;
using static AutoEatery.Api.ApiParams;

namespace AutoEatery.Api.Impl;

[ApiController]
public class UpdaterController : ControllerBase, IUpdaterApi
{
    private readonly EateryDbContext _db;

    public UpdaterController(EateryDbContext db)
    {
        _db = db;
    }

    [HttpPut(API_SUPPLIERS)]
    public IActionResult ChangeSupplier([FromBody] Supplier supplier)
    {
        return Change(supplier);
    }

    [HttpPut(API_DISHES)]
    public IActionResult ChangeDish([FromBody] Dish dish)
    {
        return Change(dish);
    }

    [HttpPut(API_ORDERS)]
    public IActionResult ChangeOrder([FromBody] Order order)
    {
        return Change(order);
    }

    [HttpPut(API_INGREDIENTS)]
    public IActionResult ChangeIngredient([FromBody] Ingredient ingredient)
    {
        return Change(ingredient);
    }

    private IActionResult Change<E>(E entity) where E : BaseEntity
    {
        var foundEntity = _db.Set<E>().SingleOrDefault(e => e.Id == entity.Id);
        
        if (foundEntity == null)
        {
            throw new ArgumentException("Entity not found by id " + entity.Id);
        }

        _db.Update(foundEntity);
        return Ok();
    }
}