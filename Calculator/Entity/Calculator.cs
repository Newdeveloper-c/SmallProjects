
namespace Calculator.Entity;

public static partial class Calculator
{
    private static List<string> list = new List<string>();
    public static void GetInput()
    {
        list.Clear();
        string input;
        do
        {
            input = Console.ReadLine();
            if (input == string.Empty)
                continue;
            list.Add(input);
        }
        while (input != EndingSymbol.ToString());
    }

    public static void PrintResult() 
    {
        foreach (var item in list)
        {
            if(double.TryParse(item, out double result)) { }
        }
    }
    
    public static void Info()
    {
        Console.WriteLine("Calculatordan foydalanish yo'riqnomasi\n" +
                          "bitta qatorga yozish mumkin, faqat\n" +
                          "\t- son (butun yoki o'nli kasr). Masalan: 3 yoki 2,41\n" +
                          "\t- arifmatik amal. Masalan: + yoki ^\n" +
                          "\t- maxsus matematik operatsiya, bo'sh joy va son. Masalan: sin 3 yoki log 10\n" +
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
                          "\t- son !, sonning faktoriali\n" +
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
