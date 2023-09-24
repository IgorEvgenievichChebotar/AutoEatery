using AutoEatery.Models;
using AutoEatery.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers.Impl;

[ApiController]
public class UpdaterController : ControllerBase, IUpdaterApi
{
    private const string CHANGE_SUPPLIER_PATH = "/put/supplier";

    private readonly IPseudoDatabase _db;

    public UpdaterController(IPseudoDatabase db)
    {
        _db = db;
    }

    [HttpPut(CHANGE_SUPPLIER_PATH)]
    public IActionResult ChangeSupplier([FromBody] Supplier supplier)
    {
        var foundSupplier = _db.Suppliers.SingleOrDefault(d => d.Id == supplier.Id);

        if (foundSupplier == null)
        {
            throw new ArgumentException("Supplier not found by id " + supplier.Id);
        }

        _db.UpdateSupplier(foundSupplier);

        return Ok(foundSupplier);
    }
}