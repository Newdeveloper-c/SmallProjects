using Shapes.Interfaces;

namespace Shapes.Entity;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius = 0)
    => this.Radius = radius;

    public double CalculatePerimeter() 
    => 2 * Math.PI * Radius;

    public double CalculateArea() 
    => Math.PI * Radius * Radius;
}
