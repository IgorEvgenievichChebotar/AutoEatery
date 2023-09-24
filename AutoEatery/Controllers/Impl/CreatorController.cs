using AutoEatery.Models;
using AutoEatery.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers.Impl;

[ApiController]
public class CreatorController : ControllerBase, ICreatorApi
{
    private const string ADD_SUPPLIER_PATH = "/post/supplier";
    private readonly IPseudoDatabase _db;

    public CreatorController(IPseudoDatabase db)
    {
        _db = db;
    }

    [HttpPost(ADD_SUPPLIER_PATH)]
    public IActionResult AddSupplier([FromBody] Supplier supplier)
    {
        _db.Suppliers.Add(supplier);
        return Ok();
    }
}