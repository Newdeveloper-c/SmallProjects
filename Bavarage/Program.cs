using Bavarage.Entity;
using Bavarage.Entity.Enums;

Beverage beverage1 = new Beverage();
Console.WriteLine($"Calories: {beverage1.CalculateCalories()}");  
beverage1.PrintAllInfo();
Console.WriteLine();

Beverage beverage2 = new Beverage
{
    Name = "Pepsi",
    Manufacturer = "PepsiCola co",
    Origin = "USA",
    Type = EBeverageType.SoftDrink,
    IsCarbonated = true,
    Volume = 0.5,
    ExpirationDate = new DateTime(2023,12,12),
    Price = 6000
};
Console.WriteLine($"Calories: {beverage2.CalculateCalories()}");
beverage2.PrintAllInfo();
Console.WriteLine();

Beverage beverage3 = new Beverage("Lipton", 
                                  EBeverageType.Tea, 
                                  new DateTime(2023, 07, 05), 
                                  5599.99M);
Console.WriteLine($"Calories: {beverage3.CalculateCalories()}");
beverage3.PrintAllInfo();
Console.WriteLine();

Beverage beverage4 = new Beverage("Red Bull",
                                  "Red Bull GmbH",
                                  EBeverageType.EnergyDrink,
                                  true,
                                  new DateTime(2024, 08, 19),
                                  0.45,
                                  2.2M,
                                  "USA"
                                  );
beverage4.Ingredients = new List<Tuple<string, int, int>>()
{
    new Tuple<string, int, int>("caffeine", 50, 100),
    new Tuple<string, int, int>("taurine", 30, 150),
    new Tuple<string, int, int>("glucuronolactone", 20, 75),
};

Console.WriteLine(beverage4.CalculateCalories());  
beverage4.PrintAllInfo();
Console.WriteLine();