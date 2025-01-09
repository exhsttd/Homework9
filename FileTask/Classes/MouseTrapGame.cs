using FileTask.Enums;
using FileTask.Interfaces;

namespace FileTask.Classes;

public class MouseTrapGame : IGameStrategy
{
    public GameType GameType => GameType.Мышеловка;
    public bool Play()
    {
        Console.WriteLine("\nКоманда играет в мышеловку:");
        return new Random().Next(0, 2) == 0;
    }
}
