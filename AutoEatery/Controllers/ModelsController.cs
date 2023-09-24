using AutoEatery.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers;

public class ModelsController : ControllerBase
{
    private const string HAL_MIME_TYPE = "application/hal+json";
    private const string API_MODELS_PATH = "/api/models";

    private readonly IPseudoDatabase _db;

    public ModelsController(IPseudoDatabase db)
    {
        _db = db;
    }

    [HttpGet(API_MODELS_PATH + "/{id:int}")]
    [Produces(HAL_MIME_TYPE)]
    public IActionResult GetSupplier(int id)
    {
        var model = _db.Dishes.Single(d => d.Id == id);
        var resource = model.ToDynamic();
        resource._actions = new
        {
            create = new
            {
                href = "/post/supplier",
                type = "application/json",
                method = "POST",
                name = "Create a new supplier"
            },
            update = new
            {
                href = "/update/supplier",
                type = "application/json",
                method = "PUT",
                name = "Update existing supplier"
            },
            delete = new
            {
                href = "/delete/supplier",
                type = "application/json",
                method = "DELETE",
                name = "Delete supplier by id"
            }
        };
        return Ok(resource);
    }
}