namespace Hometask1;

public class Product
{
    private readonly string _name;
    public string Name
    {
        get => _name;
        private init
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;
                return;
            }
            Console.WriteLine("Name should not be null or empty!");
        }
    }

    private readonly decimal _price;
    public decimal Price
    {
        get => _price;
        private init
        {
            if (value > 0)
            {
                _price = value;
                return;
            }
            Console.WriteLine("Price should not be less than 0!");
        }
    }

    private readonly double _weight;
    public double Weight
    {
        get => _weight;
        private init
        {
            if (value > 0)
            {
                _weight = value;
                return;
            }
            Console.WriteLine("Weight should not be less than 0!");
        }
    }

    public override string ToString() => $"Name: {Name}\tprice: {Price}\tweight: {Weight}";

    public Product(string name, decimal price, double weight)
    {
        Name = name;
        Price = price ;
        Weight = weight;
    } 
}