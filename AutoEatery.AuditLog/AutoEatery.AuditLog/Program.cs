using AutoEatery.Messages;
using EasyNetQ;
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
await bus.PubSub.SubscribeAsync<NewOrderMessage>(subId, LogOrderMessageReceived);

Console.ReadLine();
return;

void LogOrderMessageReceived(NewOrderMessage newOrderMessage)
{
    var dishes = string.Join(" ", newOrderMessage.Dishes
        .Select(d => $"Dish(price={d.Price}, calories={d.Calories}, cookedAt={d.CookedAt})"));
    var fullPrice = newOrderMessage.Dishes
        .Sum(d => d.Price);
    Console.WriteLine($"Received order. Dishes: {dishes}, full price: {fullPrice}");
}