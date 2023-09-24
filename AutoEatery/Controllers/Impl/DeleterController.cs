using AutoEatery.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers.Impl;

[ApiController]
public class DeleterController : ControllerBase, IDeleterApi
{
    private const string DELETE_SUPPLIER_PATH = "/delete/supplier";

    private readonly IPseudoDatabase _db;

    public DeleterController(IPseudoDatabase db)
    {
        _db = db;
    }

    [HttpDelete(DELETE_SUPPLIER_PATH + "/{id:int}")]
    public IActionResult DeleteSupplier(int id)
    {
        _db.DeleteSupplier(id);

        return NoContent();
    }
}