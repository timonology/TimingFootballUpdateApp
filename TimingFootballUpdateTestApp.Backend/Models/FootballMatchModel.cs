namespace TimingFootballUpdateTestApp.Backend.Models;

public record FootballMatchModel(string MatchId, string HomeTeam, string AwayTeam, int HomeScore, int AwayScore, string Status, string Time);

//  Status e.g., "In Progress", "Finished", "Not Started"
