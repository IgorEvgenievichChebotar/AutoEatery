using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface IModelsApi
{
    IActionResult GetActions(int id);
}