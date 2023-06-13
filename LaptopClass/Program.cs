using LaptopClass.Entity.Laptop;

public class Program
{
    static void Main(string[] args)
    {
        var laptop = new Laptop();
        var asus = new Laptop();
        Console.WriteLine(laptop.GetHashCode());
        Console.WriteLine(asus.GetHashCode());
        Console.WriteLine(Equals(laptop, asus));
        Enum.Parse(typeof(Laptop), laptop.ToString());
        asus = laptop;
        Console.WriteLine(Equals(laptop, asus));
    }
}