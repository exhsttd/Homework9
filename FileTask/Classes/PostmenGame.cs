using FileTask.Enums;
using FileTask.Interfaces;

namespace FileTask.Classes;

public class PostmenGame : IGameStrategy
{
    public GameType GameType => GameType.Почтальоны;

    public bool Play()
    {
        Console.WriteLine("\nКоманда играет в почтальонов:");
        return new Random().Next(0, 2) == 0;
    }
}
