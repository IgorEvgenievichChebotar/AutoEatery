using AutoEatery.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers.Impl;

[ApiController]
public class ReaderController : ControllerBase, IReaderApi
{
    private const string READ_ORDERS_PATH = "/read/orders";
    private const string READ_DISHES_PATH = "/read/dishes";
    private const string READ_SUPPLIERS_PATH = "/read/suppliers";
    private const string READ_INGREDIENTS_PATH = "/read/ingredients";

    private const int PAGE_SIZE = 25;
    private const string HAL_MIME_TYPE = "application/hal+json";

    private readonly IPseudoDatabase _db;

    public ReaderController(IPseudoDatabase _db)
    {
        this._db = _db;
    }

    [HttpGet(READ_ORDERS_PATH)]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult ReadOrders(int index = 0, int count = PAGE_SIZE)
    {
        var items = _db.Orders.Skip(index).Take(count);
        var total = _db.Orders.Count;
        var _links = HAL.PaginateAsDynamic(READ_ORDERS_PATH, index, count, total);
        var result = new
        {
            _links,
            count,
            total,
            index,
            items
        };
        return Ok(result);
    }

    [HttpGet(READ_DISHES_PATH)]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult ReadDishes(int index = 0, int count = PAGE_SIZE)
    {
        var items = _db.Dishes.Skip(index).Take(count);
        var total = _db.Dishes.Count;
        var _links = HAL.PaginateAsDynamic(READ_DISHES_PATH, index, count, total);
        var result = new
        {
            _links,
            count,
            total,
            index,
            items
        };
        return Ok(result);
    }

    [HttpGet(READ_SUPPLIERS_PATH)]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult ReadSuppliers(int index = 0, int count = PAGE_SIZE)
    {
        var items = _db.Suppliers.Skip(index).Take(count);
        var total = _db.Suppliers.Count;
        var _links = HAL.PaginateAsDynamic(READ_SUPPLIERS_PATH, index, count, total);
        var result = new
        {
            _links,
            count,
            total,
            index,
            items
        };
        return Ok(result);
    }

    [HttpGet(READ_INGREDIENTS_PATH)]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult ReadIngredients(int index = 0, int count = 25)
    {
        var items = _db.Ingredients.Skip(index).Take(count);
        var total = _db.Ingredients.Count;
        var _links = HAL.PaginateAsDynamic(READ_INGREDIENTS_PATH, index, count, total);
        var result = new
        {
            _links,
            count,
            total,
            index,
            items
        };
        return Ok(result);
    }
}