using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers;

public interface IDeleterApi
{
    IActionResult DeleteSupplier(int id);
}