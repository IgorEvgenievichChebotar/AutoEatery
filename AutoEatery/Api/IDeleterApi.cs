using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface IDeleterApi
{
    IActionResult DeleteSupplier(int id);
    IActionResult DeleteOrder(int id);
    IActionResult DeleteDishes(int id);
    IActionResult DeleteIngredients(int id);
}