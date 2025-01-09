using FileTask.Enums;
using FileTask.Interfaces;

namespace FileTask.Classes;

public class BeachGame : IGameStrategy
{
    public GameType GameType => GameType.Пляж;

    public bool Play()
    {
        Console.WriteLine("\nКоманда играет в пляж:");
        return new Random().Next(0, 2) == 0; 
    }
}
