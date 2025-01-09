using FileTask.Enums;
using FileTask.Interfaces;

namespace FileTask.Classes;

public class HillGame : IGameStrategy
{
    public GameType GameType => GameType.Горка;

    public bool Play()
    {
        Console.WriteLine("\nКоманда играет в горку:");
        return new Random().Next(0, 2) == 0;
    }
}
