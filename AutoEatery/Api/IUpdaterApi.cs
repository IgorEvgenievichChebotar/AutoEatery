using AutoEatery.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface IUpdaterApi
{
    IActionResult ChangeSupplier([FromBody] Supplier supplier);
}