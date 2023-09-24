using AutoEatery.Data;
using AutoEatery.Data.Models;
using Microsoft.AspNetCore.Mvc;
using static AutoEatery.Api.ApiParams;

namespace AutoEatery.Api.Impl;

[ApiController]
public class DeleterController : ControllerBase, IDeleterApi
{
    private readonly EateryDbContext _db;

    public DeleterController(EateryDbContext db)
    {
        _db = db;
    }

    [HttpDelete(API_SUPPLIERS + "/{id:int}")]
    public IActionResult DeleteSupplier(int id)
    {
        return Delete<Supplier>(id);
    }

    [HttpDelete(API_ORDERS + "/{id:int}")]
    public IActionResult DeleteOrder(int id)
    {
        return Delete<Order>(id);
    }

    [HttpDelete(API_DISHES + "/{id:int}")]
    public IActionResult DeleteDishes(int id)
    {
        return Delete<Dish>(id);
    }

    [HttpDelete(API_INGREDIENTS + "/{id:int}")]
    public IActionResult DeleteIngredients(int id)
    {
        return Delete<Ingredient>(id);
    }

    private IActionResult Delete<E>(int id) where E : BaseEntity
    {
        _db.Set<E>().Remove(_db.Set<E>().Single(e => e.Id == id));
        return NoContent();
    }
}