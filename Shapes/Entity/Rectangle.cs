using Shapes.Interfaces;

namespace Shapes.Entity;

public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea() => Length * Width;

    public double CalculatePerimeter() => 2 * (Length + Width);
}
