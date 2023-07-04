using Shapes.Interfaces;

namespace Shapes.Entity;

public class Ellipse : IShape
{
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }

    public double CalculateArea() => Math.PI * MajorAxis * MinorAxis;

    public double CalculatePerimeter()
    {
        double a = MajorAxis / 2;
        double b = MinorAxis / 2;
        return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
    }
}
