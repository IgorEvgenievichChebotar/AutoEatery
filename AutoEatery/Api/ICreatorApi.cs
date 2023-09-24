using AutoEatery.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface ICreatorApi
{
    IActionResult AddSupplier([FromBody] Supplier supplier);
    IActionResult AddOrder([FromBody] Order order);
    IActionResult AddDishes([FromBody] Dish dish);
    IActionResult AddIngredients([FromBody] Ingredient ingredient);
}