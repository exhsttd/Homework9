namespace FileTask.Classes;

public class Race
{
    private readonly List<Team> teams;
    public Race()
    {
        teams = new List<Team>();
    }
    public void AddTeam(Team team)
    {
        teams.Add(team);
    }
    public void StartRace()
    {
        foreach (var team in teams)
        {
            team.PlayGames();
        }
    }
}
