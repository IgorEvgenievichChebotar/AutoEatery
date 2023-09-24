using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface IDeleterApi
{
    IActionResult DeleteSupplier(int id);
}