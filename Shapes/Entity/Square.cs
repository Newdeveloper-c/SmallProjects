using Shapes.Interfaces;

namespace Shapes.Entity;

public class Square : IShape
{
    public double SideLength { get; set; }

    public double CalculateArea() => SideLength * SideLength;

    public double CalculatePerimeter() => 4 * SideLength;
}
