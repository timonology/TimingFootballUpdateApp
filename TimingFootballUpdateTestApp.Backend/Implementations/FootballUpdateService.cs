using Microsoft.AspNetCore.SignalR;
using TimingFootballUpdateTestApp.Backend.Hubs;
using TimingFootballUpdateTestApp.Backend.Interfaces;
using TimingFootballUpdateTestApp.Backend.Models;

namespace TimingFootballUpdateTestApp.Backend.Implementations;

public class FootballUpdateService : IFootballUpdateService
{
    private readonly List<FootballMatchModel> _sampleMatches;
    private readonly Random _random;

    public FootballUpdateService()
    {
        _sampleMatches = GenerateSampleMatches();
        _random = new Random();
    }

    public FootballMatchModel GetRandomMatch()
    {
        var randomMatchIndex = _random.Next(_sampleMatches.Count);
        return _sampleMatches[randomMatchIndex];
    }

    private List<FootballMatchModel> GenerateSampleMatches()
    {
        // Generate sample football matches 
        return new List<FootballMatchModel>
        {
            new FootballMatchModel("1", "Team A", "Team B", 2, 1, "In Progress", "45'"),
            new FootballMatchModel("2", "Team C", "Team D", 0, 0, "Not Started", "0'"),
            new FootballMatchModel("3", "Team X", "Team Y", 1, 3, "Finished", "FT"),
        };
    }


}
