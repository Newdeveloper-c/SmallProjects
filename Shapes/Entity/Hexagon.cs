using Shapes.Interfaces;

namespace Shapes.Entity;

public class Hexagon : IShape
{
    public int NumberOfSides { get; } = 6;
    public double SideLength { get; }

    public Hexagon(double sideLength = 0)
    => SideLength = sideLength;

    public double CalculateArea()
    {
        double area = (3 * Math.Sqrt(3) * Math.Pow(SideLength, 2)) / 2;
        return area;
    }

    public double CalculatePerimeter()
    {
        return NumberOfSides * SideLength;
    }
}
