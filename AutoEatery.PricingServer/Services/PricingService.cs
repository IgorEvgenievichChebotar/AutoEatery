using Auto.PricingEngine;
using Grpc.Core;

namespace AutoEatery.PricingServer.Services;

public class PricingService : Pricer.PricerBase
{
    private readonly ILogger<PricingService> _logger;

    public PricingService(ILogger<PricingService> logger)
    {
        _logger = logger;
    }

    public override Task<PriceReply> GetPrice(PriceRequest request, ServerCallContext context)
    {
        var prices = string.Join(" ", request.DishList);
        var sum = request.DishList.Sum(x => x.Price);
        _logger.LogInformation($"PriceRequest: {prices}");
        _logger.LogInformation($"Result sum: {sum}");
        return Task.FromResult(new PriceReply { Price = sum });
        
    }
}