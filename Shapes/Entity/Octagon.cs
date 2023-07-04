using Shapes.Interfaces;

namespace Shapes.Entity;

public class Octagon : IShape
{
    public int NumberOfSides { get; } = 7;
    public double SideLength { get; }

    public Octagon(double sideLength = 0)
    => SideLength = sideLength;

    public double CalculateArea()
    {
        double apothem = SideLength / (2 * Math.Tan(Math.PI / NumberOfSides));
        double area = (NumberOfSides * SideLength * apothem) / 2;
        return area;
    }

    public double CalculatePerimeter() => NumberOfSides * SideLength;
}
