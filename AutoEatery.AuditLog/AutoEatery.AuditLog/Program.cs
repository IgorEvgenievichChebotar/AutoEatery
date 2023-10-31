using Auto.PricingEngine;
using AutoEatery.Messages;
using EasyNetQ;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

Console.WriteLine("Starting AutoEatery.AuditLog...");
var amqp = config.GetConnectionString("AutoRabbitMQ");
using var bus = RabbitHutch.CreateBus(amqp);
Console.WriteLine("Connected to bus. Listening for newOrderMessages");
var subId = $"Auto.AuditLog@{Environment.MachineName}";
await bus.PubSub.SubscribeAsync<NewOrderMessage>(subId, newOrderMessage =>
{
    var dishes = string.Join(" ", newOrderMessage.Dishes
        .Select(d => $"Dish(price={d.Price}, calories={d.Calories}, cookedAt={d.CookedAt})"));

    Console.WriteLine($"Dishes: {dishes}");
    
    using var channel = GrpcChannel.ForAddress("http://localhost:5128");
    var grpcClient = new Pricer.PricerClient(channel);
    var request = new PriceRequest
    {
        DishList =
        {
            newOrderMessage.Dishes
                .Select(x => new DishRequest { Price = (int)x.Price })
        }
    };
    var reply = grpcClient.GetPrice(request);
    Console.WriteLine($"Price: {reply.Price}");
});

Console.ReadLine();