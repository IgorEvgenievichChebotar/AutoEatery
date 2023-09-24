using Microsoft.AspNetCore.Mvc;
using static AutoEatery.Api.ApiParams;

namespace AutoEatery.Api.Impl;

[ApiController]
public class DiscoveryEndpointController : ControllerBase, IDiscoveryEndpointApi
{
    [HttpGet(API)]
    public IActionResult Get() {
        var welcome = new {
            _links = new {
                dishes = new {
                    href = API_DISHES
                },
                suppliers = new
                {
                    href = API_SUPPLIERS
                },
                ingredients = new
                {
                    href = API_INGREDIENTS
                },
                orders = new
                {
                    href = API_ORDERS
                }
            },
            message = "Welcome to the Auto Eatery API!",
        };
        return Ok(welcome);
    }
}