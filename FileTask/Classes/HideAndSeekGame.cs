using FileTask.Enums;
using FileTask.Interfaces;

namespace FileTask.Classes;

public class HideAndSeekGame : IGameStrategy
{
    public GameType GameType => GameType.Прятки;

    public bool Play()
    {
        Console.WriteLine("\nКоманда играет в прятки:");
        return new Random().Next(0, 2) == 0; 
    }
}
