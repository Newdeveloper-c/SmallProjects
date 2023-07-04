using Shapes.Interfaces;

namespace Shapes.Entity;

public class Trapedzoid : IShape
{
    public double Base1 { get; set; }
    public double Base2 { get; set; }
    public double Height { get; set; }
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    public double CalculateArea()
    {
        return 0.5 * (Base1 + Base2) * Height;
    }

    public double CalculatePerimeter()
    {
        return Base1 + Base2 + Side1 + Side2;
    }
}
