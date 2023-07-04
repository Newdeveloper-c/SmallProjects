namespace Shapes;

public class GeometricalFigures
{
    public delegate double PerimeterCalculationDeligate();
    public delegate double AreaCalculationDeligate();

    public void PrintAreaAndPerimeter(AreaCalculationDeligate areaMethod,
                                      PerimeterCalculationDeligate perimeterMethod)
    {
        Console.WriteLine($"area = {areaMethod()}\n" +
                          $"perimeter = {perimeterMethod()}\n");
    }
}
