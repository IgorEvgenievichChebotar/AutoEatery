using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Controllers;

public interface IReaderApi
{
    IActionResult ReadOrders(int index = 0, int count = 25);
    IActionResult ReadDishes(int index = 0, int count = 25);
    IActionResult ReadSuppliers(int index = 0, int count = 25);
    IActionResult ReadIngredients(int index = 0, int count = 25);
}