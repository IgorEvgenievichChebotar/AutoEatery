using AutoEatery.Data;
using AutoEatery.Data.Models;
using AutoEatery.Services;
using Microsoft.AspNetCore.Mvc;
using static AutoEatery.Api.ApiParams;

namespace AutoEatery.Api.Impl;

[ApiController]
public class ReaderController : ControllerBase, IReaderApi
{
    private const int PAGE_SIZE = 25;
    private const string HAL_MIME_TYPE = "application/hal+json";

    private readonly EateryDbContext _db;

    public ReaderController(EateryDbContext _db)
    {
        this._db = _db;
    }

    [HttpGet(API_ORDERS)]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult ReadOrders(int index = 0, int count = PAGE_SIZE)
    {
        return Read<Order>(API_ORDERS, index, count);
    }

    [HttpGet(API_DISHES)]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult ReadDishes(int index = 0, int count = PAGE_SIZE)
    {
        return Read<Dish>(API_DISHES, index, count);
    }

    [HttpGet(API_SUPPLIERS)]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult ReadSuppliers(int index = 0, int count = PAGE_SIZE)
    {
        return Read<Supplier>(API_SUPPLIERS, index, count);
    }

    [HttpGet(API_INGREDIENTS)]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult ReadIngredients(int index = 0, int count = PAGE_SIZE)
    {
        return Read<Ingredient>(API_INGREDIENTS, index, count);
    }

    [HttpGet($"{API_SUPPLIERS}/" + "{id:int}")]
    public IActionResult GetSuppliers(int id)
    {
        return Ok(_db.Suppliers.Single(x => x.Id == id));
    }

    [HttpGet($"{API_ORDERS}/" + "{id:int}")]
    public IActionResult GetOrders(int id)
    {
        return Ok(_db.Orders.Single(x => x.Id == id));
    }

    [HttpGet($"{API_INGREDIENTS}/" + "{id:int}")]
    public IActionResult GetIngredients(int id)
    {
        return Ok(_db.Ingredients.Single(x => x.Id == id));
    }

    [HttpGet($"{API_DISHES}/" + "{id:int}")]
    public IActionResult GetDishes(int id)
    {
        return Ok(_db.Dishes.Single(x => x.Id == id));
    }

    private IActionResult Read<E>(
        string apiPath,
        int index,
        int count
    ) where E : BaseEntity
    {
        var items = _db.Set<E>().Skip(index).Take(count).Select(x => x.ToResource(apiPath, x.Id));
        var total = _db.Set<E>().Count();
        var _links = HAL.PaginateAsDynamic(apiPath, index, count, total);
        var _actions = GetActions(apiPath);
        var result = new
        {
            _links,
            _actions,
            count,
            total,
            index,
            items
        };
        return Ok(result);
    }

    private static dynamic GetActions(string endpoint)
    {
        return new
        {
            create = new
            {
                href = endpoint + "/{id}",
                type = "application/json",
                method = "POST",
                name = "Create a new supplier"
            },
            update = new
            {
                href = endpoint + "/{id}",
                type = "application/json",
                method = "PUT",
                name = "Update existing supplier"
            },
            delete = new
            {
                href = endpoint + "/{id}",
                type = "application/json",
                method = "DELETE",
                name = "Delete supplier by id"
            }
        };
    }
}