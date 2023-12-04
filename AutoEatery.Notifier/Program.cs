using Microsoft.AspNetCore.SignalR.Client;

const string signalrHubUrl = "http://localhost:5018/hub";

var hub = new HubConnectionBuilder().WithUrl(signalrHubUrl).Build();
await hub.StartAsync();
Console.WriteLine("Hub started!");
Console.WriteLine("Press any key to send a message (Ctrl-C to quit)");
var i = 0;
while (true)
{
    var input = Console.ReadLine();
    var message = $"Message #{i++} from AutoEatery.Notifier {input}";
    await hub.SendAsync("NotifyWebUsers", "AutoEatery.Notifier", message);
    Console.WriteLine($"Sent: {message}");
}