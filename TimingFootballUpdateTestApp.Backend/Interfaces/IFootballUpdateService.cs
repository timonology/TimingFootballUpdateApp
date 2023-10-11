using TimingFootballUpdateTestApp.Backend.Models;

namespace TimingFootballUpdateTestApp.Backend.Interfaces;

public interface IFootballUpdateService
{
    FootballMatchModel GetRandomMatch();
}
