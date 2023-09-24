using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface IReaderApi
{
    IActionResult ReadOrders(int index = 0, int count = 25);
    IActionResult ReadDishes(int index = 0, int count = 25);
    IActionResult ReadSuppliers(int index = 0, int count = 25);
    IActionResult ReadIngredients(int index = 0, int count = 25);
    IActionResult GetSuppliers(int id);
    IActionResult GetOrders(int id);
    IActionResult GetIngredients(int id);
    IActionResult GetDishes(int id);
}