using Microsoft.AspNetCore.SignalR;

namespace WebSocketHub;

public class EateryHub : Hub
{
    public async Task NotifyWebUsers(string user, string message)
    {
        await Clients.All.SendAsync("DisplayNotification", user, message);
    }
}