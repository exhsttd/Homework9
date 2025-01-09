using FileTask.Enums;
using FileTask.Interfaces;

namespace FileTask.Classes;

public class FishingGame : IGameStrategy
{
    public GameType GameType => GameType.Рыбалка;

    public bool Play()
    {
        Console.WriteLine("\nКоманда играет в рыбалку:");
        return new Random().Next(0, 2) == 0; 
    }
}
