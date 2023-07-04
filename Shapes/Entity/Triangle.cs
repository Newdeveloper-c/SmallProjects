using Shapes.Interfaces;

namespace Shapes.Entity;

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
}
