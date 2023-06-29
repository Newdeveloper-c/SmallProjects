
namespace Calculator.Entity;

public static partial class Calculator
{
    private static double ModulDivision(int a = 0, int b = 1)
    => a % b;

    private static double Power(double number, int power)
    {
        if (power < 0)
        {
            number = 1 / number;
            power = -power;
        }

        if (power < 2)
            return power == 0 ? 1 : number;

        double answer = number;
        while (power-- > 0)
            answer = Multiply(answer, number);

        return answer;
    }

    private static double Power(double number, double power)
    => Math.Pow(number, power);

    private static double SquareRoot(double number)
    => Math.Sqrt(number);

    private static long Factorial(int number)
    {
        if (number < 0)
            throw new Exception("Faktorialga musbat qiymat kiritilishi kerak !!!");

        long answer = 1;
        while (number > 0)
            answer *= number--;

        return answer;
    }

    private static double Log(double number, double baseNumber)
    {
        if (number < 0 || baseNumber < 0 || baseNumber == 1)
            throw new Exception("Logarifmga xato qiymat kiritilgan !!!");
        return Math.Log(number, baseNumber);
    }

}