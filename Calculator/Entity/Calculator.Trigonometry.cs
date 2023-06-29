namespace Calculator.Entity;

public static partial class Calculator
{
	private static double Sin(double number)
	=> Math.Sin(number);

	private static double Cos(double number)
	=> Math.Cos(number);

	private static double Tan(double number)
	=> Math.Tan(number);

	private static double Cot(double number)
	=> 1 / Math.Tan(number);

	private static double ArcSin(double number)
	=> Math.Asin(number);

	private static double ArcCos(double number)
	=> Math.Acos(number);

	private static double ArcTan(double number)
	=> Math.Atan(number);

	private static double ArcCot(double number)
	=> Math.Atan(1 / number);
}