﻿using Microsoft.AspNetCore.SignalR;
using TimingFootballUpdateTestApp.Backend.Interfaces;
using TimingFootballUpdateTestApp.Backend.Models;

namespace TimingFootballUpdateTestApp.Backend.Hubs;

public class FootballUpdatesHub : Hub
{
    private readonly IFootballUpdateService _footballService;
    private CancellationTokenSource _cancellationTokenSource;

    public FootballUpdatesHub(IFootballUpdateService footballService)
    {
        _footballService = footballService;
    }

    public async Task StartStreaming()
    {
        _cancellationTokenSource = new CancellationTokenSource();

        while (!_cancellationTokenSource.Token.IsCancellationRequested)
        {
            var randomMatch = _footballService.GetRandomMatch(); // am using a sample match for my data source
            await Clients.All.SendAsync("ReceiveFootballMatch", randomMatch);
            await Task.Delay(4000); // Delay for 4 seconds
        }
    }

    public async Task StopStreaming()
    {
        _cancellationTokenSource?.Cancel();
    }

}
