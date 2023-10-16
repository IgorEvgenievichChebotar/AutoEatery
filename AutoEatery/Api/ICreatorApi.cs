using AutoEatery.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface ICreatorApi
{
    Task<IActionResult> AddSupplier([FromBody] Supplier supplier);
    Task<IActionResult> AddOrder([FromBody] Order order);
    Task<IActionResult> AddDishes([FromBody] Dish dish);
    Task<IActionResult> AddIngredients([FromBody] Ingredient ingredient);
}