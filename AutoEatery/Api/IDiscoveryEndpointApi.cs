using Microsoft.AspNetCore.Mvc;

namespace AutoEatery.Api;

public interface IDiscoveryEndpointApi
{
    IActionResult Get();
}