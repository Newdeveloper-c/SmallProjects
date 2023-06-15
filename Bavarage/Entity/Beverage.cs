using Bavarage.Entity.Enums;

namespace Bavarage.Entity;

public class Beverage
{
    //Properties
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public bool IsCarbonated { get; set; }
    public double Volume { get; set; }  // in milliliters
    public string Origin { get; set; } //Represents the origin or country of the beverage
    public DateTime ExpirationDate { get; set; }
    public EBeverageType Type { get; set; }
    
    /// <summary>
    /// in {string} name of ingredient
    /// in 1st {int} amount of this ingredient 
    /// in 2nd {int} amount of calory for 100grs
    /// </summary>
    public List<Tuple<string, int, int>> Ingredients { get; set; }

    //Constructors
    public Beverage() { } // Default constructor
    public Beverage(string name, 
                    EBeverageType type, 
                    DateTime expirationDate, 
                    decimal price)              //minimal constructor
    {
        Name = name;
        Type = type;
        ExpirationDate = expirationDate;
        Price = price;
    }
    public Beverage(string name, 
                    string manufacturer, 
                    EBeverageType type, 
                    bool isCarbonated, 
                    DateTime expirationDate,
                    double volume,
                    decimal price,
                    string origin = "",
                    List<Tuple<string, int, int>> ingredients = null)
    {
        Name = name;
        Manufacturer = manufacturer;
        Price = price;
        IsCarbonated = isCarbonated;
        Volume = volume;
        Ingredients = ingredients;
        Origin = origin;
        ExpirationDate = expirationDate;
        Type = type;
    }

    //methods
    public int CalculateCalories()
    {
        int totalCalories = 0;

        if(Ingredients == null)
            return totalCalories;

        foreach (var ingredient in Ingredients)
        {
            int ingredientAmount = ingredient.Item2; // Amount of ingredient in the beverage
            int caloriesPer100g = ingredient.Item3; // Calorie content of the ingredient per 100 grams

            double ingredientRatio = ingredientAmount / 100.0; // Calculate the ratio of the ingredient in the beverage (assuming the ingredient amount is in grams)

            int ingredientCalories = (int)(caloriesPer100g * ingredientRatio); // Calculate the calories contributed by this ingredient

            totalCalories += ingredientCalories; // Add to the total calories
        }

        return totalCalories;
    }

    public void PrintAllInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Is Carbonated: {IsCarbonated}");
        Console.WriteLine($"Volume: {Volume} mL");
        Console.WriteLine($"Origin: {Origin}");
        Console.WriteLine($"Expiration Date: {ExpirationDate}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine("Ingredients:");

        if( Ingredients != null )
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"- {ingredient.Item1}: {ingredient.Item2} grams");
            }
    }
}

