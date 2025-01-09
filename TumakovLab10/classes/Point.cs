using HomeWork9.Enums;

namespace HomeWork9.classes;
public class Point : Figure
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y, Colors color, Visibility visibility)
        : base(color, visibility)
    {
        X = x;
        Y = y;
    }

    public override void Output()
    {
        Console.WriteLine($"Координаты точки: ({X}, {Y}), Цвет: {Color}, Видимость: {Visibility}");
    }

    public void Move(double horizontal, double vertical)
    {
        X += horizontal;
        Y += vertical;
    }
}