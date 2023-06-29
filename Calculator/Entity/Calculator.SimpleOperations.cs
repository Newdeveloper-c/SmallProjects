namespace Calculator.Entity;

public static partial class Calculator
{
    private static double Add(double a = 0, double b = 0)
    => a + b;

    private static double Subtract(double a = 0, double b = 0)
    => a - b;

    private static double Multiply(double a = 0, double b = 0)
    => a * b;

    private static double Divide(double a = 0, double b = 1)
    => a / b;
}