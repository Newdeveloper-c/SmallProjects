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
	=> number >= -1 && number <= 1 ? Math.Asin(number) : throw new Exception("asin qiymati -1 va 1 orlig'ida bo'lishi shart !!!");

	private static double ArcCos(double number)
	=> number >= -1 && number <= 1 ? Math.Acos(number) : throw new Exception("acos qiymati -1 va 1 orlig'ida bo'lishi shart !!!");

	private static double ArcTan(double number)
	=> Math.Atan(number);

	private static double ArcCot(double number)
	=> Math.Atan(1 / number);
}