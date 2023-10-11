using Microsoft.AspNetCore.SignalR;

namespace TimingFootballUpdateTestApp.Backend.Hubs;

public class FootballUpdatesHub : Hub
{
    public async Task SendUpdate(string message)
    {
        await Clients.All.SendAsync("ReceiveUpdate", message);
    }
}
