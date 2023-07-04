using Shapes.Interfaces;

namespace Shapes.Entity;

public class NGon : IShape
{
    public int NumberOfSides { get; }
    public double SideLength { get; }

    public NGon(int numberOfSides = 1, double sideLength = 0)
    {
        NumberOfSides = numberOfSides;
        SideLength = sideLength;
    }

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
