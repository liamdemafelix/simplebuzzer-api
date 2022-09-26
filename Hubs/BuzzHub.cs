using Microsoft.AspNetCore.SignalR;

namespace SimpleBuzzer.Hubs;

public class BuzzHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}