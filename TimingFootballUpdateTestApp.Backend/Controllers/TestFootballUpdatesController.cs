using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TimingFootballUpdateTestApp.Backend.Hubs;
using TimingFootballUpdateTestApp.Backend.Interfaces;
using TimingFootballUpdateTestApp.Backend.Models;

namespace TimingFootballUpdateTestApp.Backend.Controllers;

public class TestFootballUpdatesController : ControllerBase
{
    private readonly IHubContext<FootballUpdatesHub> _hubContext;

    public TestFootballUpdatesController(IHubContext<FootballUpdatesHub> hubContext)
    {
        _hubContext = hubContext;
    }

    [HttpPost("start")]
    public async Task<IActionResult> StartStreaming()
    {
        await _hubContext.Clients.All.SendAsync("ReceiveFootballMatch", "Streaming started.");
        await _hubContext.Clients.All.SendAsync("StartStreaming");
        return Ok("Streaming started.");
    }

    [HttpPost("stop")]
    public async Task<IActionResult> StopStreaming()
    {
        await _hubContext.Clients.All.SendAsync("ReceiveFootballMatch", "Streaming stopped.");
        await _hubContext.Clients.All.SendAsync("StopStreaming");
        return Ok("Streaming stopped.");
    }
}
