using Shapes.Interfaces;

namespace Shapes.Entity;

public class Square : IShape
{
    public double SideLength { get; set; }

    public double CalculateArea()
    {
        return SideLength * SideLength;
    }

    public double CalculatePerimeter()
    {
        return 4 * SideLength;
    }
}
