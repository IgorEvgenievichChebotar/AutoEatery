using AutoEatery.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers;

public interface IUpdaterApi
{
    IActionResult ChangeSupplier([FromBody] Supplier supplier);
}