using HomeWork9.Enums;
using HomeWork9.interfaces;

namespace HomeWork9.classes;

public abstract class Figure
{
    public Colors Color { get; set; }
    public Visibility Visibility { get; set; }

    public Figure(Colors color, Visibility visibility)
    {
        Color = color;
        Visibility = visibility;
    }

    public void Move(double horizontal, double vertical)
    { }

    public void ChangeColor(Colors newColor)
    {
        Color = newColor;
    }

    public bool IsVisible()
    {
        return Visibility == Visibility.Visible;
    }

    public abstract void Output();
}
