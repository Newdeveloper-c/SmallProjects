using Shapes.Interfaces;

namespace Shapes.Entity;

public class Pentagon : IShape
{
    public int NumberOfSides { get; } = 5;
    public double SideLength { get; }

    public Pentagon(double sideLength = 0)
    => SideLength = sideLength;

    public double CalculateArea()
    {
        double apothem = SideLength / (2 * Math.Tan(Math.PI / NumberOfSides));
        double area = (NumberOfSides * SideLength * apothem) / 2;
        return area;
    }

    public double CalculatePerimeter()
    {
        return NumberOfSides * SideLength;
    }
}
