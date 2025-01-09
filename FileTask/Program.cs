using System;
using System.Collections.Generic;
using FileTask.Classes;
using FileTask.Enums;
using FileTask.Interfaces;
class Program
{
    static void Main(string[] args)
    {
        var newRace = new Race();
        
        var teamRussia = new Team(Country.Россия);
        var teamFrance = new Team(Country.Франция);
        var teamChina = new Team(Country.Китай);
        var teamKazakhstan = new Team(Country.Казахстан);
        
        var games = new IGameStrategy[]
        {
            new BeachGame(),
            new MouseTrapGame(),
            new SeaGame(),
            new FishingGame(),
            new PostmenGame(),
            new HillGame(),
            new HideAndSeekGame()
        };
        Random rand = new Random();
        var selectGameType = new HashSet<int>(); 

        for (int i = 0; i < 6; i++)
        {
            int index;
            index = rand.Next(0, games.Length);
            if (!selectGameType.Contains(index))
            {
                selectGameType.Add(index); 
                GameType selectType = (GameType)index;
                teamRussia.AddGame(games[index]);
                teamFrance.AddGame(games[index]);
                teamChina.AddGame(games[index]);
                teamKazakhstan.AddGame(games[index]);
            }
            else
            {
                i--; 
            }
        }
        newRace.AddTeam(teamRussia);
        newRace.AddTeam(teamFrance);
        newRace.AddTeam(teamChina);
        newRace.AddTeam(teamKazakhstan);
        newRace.StartRace();
    }
}