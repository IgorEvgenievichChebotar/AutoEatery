using AutoEatery.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers;

public interface ICreatorApi
{
    IActionResult AddSupplier([FromBody] Supplier supplier);
}