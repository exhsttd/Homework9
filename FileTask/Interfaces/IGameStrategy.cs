using FileTask.Enums;

namespace FileTask.Interfaces;

public interface IGameStrategy
{
    GameType GameType { get; }
    bool Play(); // команда либо выигрывает, либо нет с шансом 50\50 (пусть будет)
}
