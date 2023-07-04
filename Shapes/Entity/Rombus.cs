using Shapes.Interfaces;

namespace Shapes.Entity;

public class Rombus : IShape
{
    public double SideLength { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return SideLength * Height;
    }

    public double CalculatePerimeter()
    {
        return 4 * SideLength;
    }
}
