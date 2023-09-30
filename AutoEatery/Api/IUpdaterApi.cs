using AutoEatery.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface IUpdaterApi
{
    IActionResult ChangeSupplier([FromBody] Supplier supplier);
    IActionResult ChangeDish([FromBody] Dish dish);
    IActionResult ChangeOrder([FromBody] Order order);
    IActionResult ChangeIngredient([FromBody] Ingredient ingredient);
}