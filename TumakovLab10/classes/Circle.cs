
using System.Drawing;
using HomeWork9.Enums;
using HomeWork9.interfaces;
using Point = HomeWork9.classes.Point;

public class Circle : Point, IArea
{
    public double Radius { get; }

    public Circle(double radius, double x, double y, Colors color, Visibility visibility)
        : base(x, y, color, visibility)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than zero.");
        }
        Radius = radius;
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Радиус: {Radius}, Площадь: {CalculateArea()}");
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}