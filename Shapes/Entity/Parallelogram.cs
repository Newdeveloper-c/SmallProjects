using Shapes.Interfaces;

namespace Shapes.Entity;

public class Parallelogram : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double SideLength { get; set; }

    public double CalculateArea()
    {
        return Base * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Base + SideLength);
    }
}
