
namespace Calculator.Entity;

public static partial class Calculator
{    
    private static List<string> list = new List<string>();

    /// <summary>
    /// Only reads the input from the terminal
    /// </summary>
    public static void GetInput()
    {
        list.Clear();
        string input;
        do
        {
            input = Console.ReadLine();
            
            //making some corrections for input
            while(input.First() == ' ')
                input.Remove(0);
            if (input == string.Empty)
                continue;
            input.ToLower();

            list.Add(input);
        }
        while (input != ExitSymbol);

        //foreach(var item in  list) 
        //{
        //    Console.WriteLine(int.TryParse(item, out int temp));
        //}
    }

    /// <summary>
    /// Calculates the input and gives result or error
    /// </summary>
    public static void PrintResult() 
    {
        try
        {
            double result = 0;
            char operation = '+';

            foreach (var item in list)
            { 
                if (item == ExitSymbol)
                    break;

                if (double.TryParse(item, out double temp))
                {
                    result = Calculate(operation, result, temp);
                    operation = '?';
                    continue;
                }

                if (item.Length == 1)
                {
                    if (charOperationName.Contains(item))
                        operation = char.Parse(item);
                    else
                        throw new Exception("Noto'g'ri matematik amal kiritildi !");
                    continue;
                }

                if (item == piConstant)
                {
                    result = Calculate(operation, result, Pi);
                    continue;
                }

                if (item == eConstant)
                {
                    result = Calculate(operation, result, Exp);
                    continue;
                }

                var splittedItem = item.Split(' ');
                if (splittedItem.Length > 3)
                    throw new Exception("Xato malumot kiritilgan !!!");

                bool isNotContains = true;
                foreach (var word in wordOperationName.Split(' '))
                    if (splittedItem[0] == word)
                    {
                        isNotContains = false;
                        double tempResult;
                        if (splittedItem.Length == 3)
                            tempResult = Calculate(word, splittedItem[1], splittedItem[2]);
                        tempResult = Calculate(word, splittedItem[1]);
                        result = Calculate(operation, result, tempResult);
                        break;
                    }

                if (isNotContains)
                    throw new Exception("Notog'ri malumot kiritilgan !!!");

            }
            Console.WriteLine(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    private static double Calculate(char operation, double result, double temp)
    {
        if (operation == '?')
            throw new Exception("Notog'ri kiruvchi qiymat. Arifmetik amal topilmadi !!!");

        switch (operation)
        {
            case '+':
                return Add(result, temp);
                break;
            case '-':
                return Subtract(result, temp);
                break;
            case '*':
                return Multiply(result, temp);
                break;
            case '/':
                return Divide(result, temp);
                break;
            case '^':
                if(temp != (int)temp)
                    return Power(result, (int)temp);
                else
                    return Power(result, temp);
                break;
            case '%':
                if (result != (int)result || temp != (int)temp)
                    throw new Exception("Qoldiqli bo'lishda xatolik. Noto'g'ri qiymat kiritilgan !!!");
                return ModulDivision((int)result, (int)temp);
                break;
            default:
                return result;
            return result;
        }
    }

    private static double Calculate(string operation, string number, string baseNumber = "0")
    {
        double result = 0;
        if(double.TryParse(number, out double dnumber) == false || double.TryParse(baseNumber, out double dbaseNumber) == false) 
            throw new Exception("Noto'g'ri qiymat !!!");
        switch(operation)
        {
            case "log":
                if (baseNumber == "0")
                    result = Log(dnumber, 10);
                else
                    result = Log(dnumber, dbaseNumber);
                break;
            case "ln":
                result = Log(dnumber, Exp);
                break;
            case "sqrt":
                result = SquareRoot(dnumber);
                break;
            case "sin":
                result = Sin(dnumber);
                break;
            case "cos":
                result = Cos(dnumber);
                break;
            case "tan":
                result = Tan(dnumber);
                break;
            case "cot":
                result = Cot(dnumber);
                break;
            case "asin":
                result = ArcSin(dnumber);
                break;
            case "acos":
                result = ArcCos(dnumber);
                break;
            case "atan":
                result = ArcTan(dnumber);
                break;
            case "acot":
                result = ArcCot(dnumber);
                break;
            default : return result;
        }
        return result;
    }

    /// <summary>
    /// program info
    /// </summary>
    public static void Info()
    {
        Console.WriteLine("Calculatordan foydalanish yo'riqnomasi\n" +
                          "bitta qatorga yozish mumkin, faqat\n" +
                          "\t- son (butun yoki o'nli kasr). Masalan: 3 yoki 2,41\n" +
                          "\t- arifmatik amal. Masalan: + yoki ^\n" +
                          "\t- maxsus matematik operatsiya, bo'sh joy va son. Masalan: sin 3 yoki log 10\n" +
                          "\t- konstanta. Masalan: pi yoki e\n" +
                          "Arifmetik amallar quyida keltirilgan:\n" +
                          "\t- +, 2 ta sonni qo'shish\n" +
                          "\t- -, 2 ta sonni ayirish\n" +
                          "\t- *, 2 ta sonni ko'paytirish\n" +
                          "\t- /, 2 ta sonni bo'lish\n" +
                          "\t- ^, 2 ta sonni darajasi\n" +
                          "\t- %, 2 ta sonni qoldiq olish\n" +
                          "Matematik funksiyalar quyida keltirilgan:\n" +
                          "\t- sqrt son, sonning kvadrat ildizi\n" +
                          "\t- log son, sonning 10 asos logarifmi\n" +
                          "\t- log son asos, sonning asos logarifmi\n" +
                          "\t- ln son, sonning natural logarifmi\n" +
                          "\t- ! son, sonning faktoriali\n" +
                          "\t- sin son, sonning sinusi\n" +
                          "\t- cos son, sonning cosinusi\n" +
                          "\t- tan son, sonning tangensi\n" +
                          "\t- cot son, sonning kotangensi\n" +
                          "\t- asin son, sonning arcsinusi\n" +
                          "\t- acos son, sonning arccosinusi\n" +
                          "\t- atan son, sonning arctangensi\n" +
                          "\t- acot son, sonning arccotangensi\n" +
                          "!!! Trigonometrik formulalar radianlarda hisonladi !!!\n");

        //Console.WriteLine("\t\t!!! DIQQAT !!!\n" +
        //                  "Arifmetik amallarni sondan keyin kiriting. Keyin esa yana son yozing.\n" +
        //                  "Matematik funksiyalar faqar yuqorida ko'rsatilgan tartibda ishalting.\n");

    }
}
