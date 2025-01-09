using FileTask.Enums;
using FileTask.Interfaces;

namespace FileTask.Classes;
 
public class SeaGame : IGameStrategy
{
    public GameType GameType => GameType.Море;

    public bool Play()
    {
        Console.WriteLine("\nКоманда играет в море:");
        return new Random().Next(0, 2) == 0; 
    }
}
