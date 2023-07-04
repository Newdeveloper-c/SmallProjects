using Shapes.Interfaces;

namespace Shapes.Entity;

public class Rombus : IShape
{
    public double SideLength { get; set; }
    public double Height { get; set; }

    public double CalculateArea() => SideLength * Height;

    public double CalculatePerimeter() => 4 * SideLength;
}
