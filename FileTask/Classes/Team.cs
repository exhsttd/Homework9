using FileTask.Enums;
using FileTask.Interfaces;

namespace FileTask.Classes;

public class Team
{
    public Country Country { get; }
    private readonly List<IGameStrategy> games;

    public Team(Country country)
    {
        Country = country;
        games = new List<IGameStrategy>();
    }

    public void AddGame(IGameStrategy game)
    {
        games.Add(game);
    }

    public void PlayGames()
    {
        Console.WriteLine($"Сейчас играет команда: {Country} ");
        foreach (var game in games)
        {
            bool result = game.Play();
            if (result)
            {
                Console.WriteLine($"Команда {Country} выиграла в игре {game.GameType}!!");
            }
            else
            {
                Console.WriteLine($"Команда {Country} проиграла в игре {game.GameType}..");
            }
        }
        Console.WriteLine();
    }
}
