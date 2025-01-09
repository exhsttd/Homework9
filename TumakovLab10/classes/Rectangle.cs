using HomeWork9.Enums;
using HomeWork9.interfaces;

namespace HomeWork9.classes
{
    public class Rectangle : Point, IArea
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height, double x, double y, Colors color, Visibility visibility)
            : base(x, y, color, visibility)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Width and height must be greater than zero.");
            }
            Width = width;
            Height = height;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Длина: {Width}, Высота: {Height}, Площадь: {CalculateArea()}");
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}