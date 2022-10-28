namespace Hometask1;

public class Product
{
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;
                return;
            }
            Console.WriteLine("Name should not be null or empty!");
        }
    }

    private decimal _price;

    public decimal Price
    {
        get => _price;
        set
        {
            if (value > 0)
            {
                _price = value;
                return;
            }
            Console.WriteLine("Price should not be less than 0!");
        }
    }

    private double _weight;

    private double Weight
    {
        get => _weight;
        set
        {
            if (value > 0)
            {
                _weight = value;
                return;
            }
            Console.WriteLine("Weight should not be less than 0!");
        }
    }

    public virtual void ChangePrice(decimal percents) => Price += Price * 100 / percents;

    public virtual void ConsoleInput()
    {
        Console.Write("Enter name: ");
        _name = Console.ReadLine();
        Console.Write("Enter price: ");
        decimal.TryParse(Console.ReadLine(), out _price);
        Console.Write("Enter weight: ");
        double.TryParse(Console.ReadLine(), out _weight);
        Console.WriteLine();
    }

    public override string ToString() => $"Name: {Name}\tprice: {Price}\tweight: {Weight}";

    public override bool Equals(object? obj) => _name == ((Product)obj).Name && 
                                                _price == ((Product)obj).Price &&
                                                _weight == ((Product)obj).Weight;

    public override int GetHashCode() => HashCode.Combine(_name, _price, _weight);

    public Product(string name, decimal price, double weight)
    {
        Name = name;
        Price = price ;
        Weight = weight;
    }
    
    public Product() : this(string.Empty, default, default) { }
}