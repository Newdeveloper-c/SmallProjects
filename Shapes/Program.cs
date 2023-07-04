
using Shapes.Entity;
using Shapes;

GeometricalFigures geometricalFigures = new GeometricalFigures();
Rectangle rectangle = new Rectangle(4, 5);

geometricalFigures.PrintAreaAndPerimeter(rectangle.CalculatePerimeter, rectangle.CalculateArea);

