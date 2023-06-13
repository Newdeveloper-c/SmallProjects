using LaptopClass.Entity.Laptop.Enums;

namespace LaptopClass.Entity.Laptop
{
    public class Laptop
    {
        public string Name { get; set; } = null!;
        public string BrandName { get; set; } = string.Empty;
        public DateOnly ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public ELaptopType Type { get; set; } = ELaptopType.Gaming;
        public double Weight { get; set; }
        //public Ram Ram { get; set; }
        public EColorType Color { get; set; } = 0;
        public Laptop() : this("acer")
        { }
        public Laptop(string name)
        {
            Name = name;
        }
    }
}