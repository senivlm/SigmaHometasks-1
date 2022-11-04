using Hometask1.Enums;

namespace Hometask1;

public class Product : IComparable, ICloneable
{
    private (decimal Value, Currency Currency) _price;
    public (decimal Value, Currency Currency) Price
    {
        get => _price;
        set
        {
            if (value.Value > 0)
            {
                _price = value;
                return;
            }
            Console.WriteLine("Price is less than 0");
        }
    }
    
    private (double Value, WeightUnit WeightUnit) _weight;
    public (double Value, WeightUnit WeightUnit) Weight
    {
        get => _weight;
        set
        {
            if (value.Value > 0)
            {
                _weight = value;
                return;
            }
            Console.WriteLine("Weight should not be less than 0!");
        }
    }

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

    public virtual void ChangePrice(decimal percents) 
        => Price = (Price.Value + Price.Value * 100 / percents, Price.Currency);

    public virtual void ConsoleInput()
    {
        Console.Write("Enter name:");
        _name = Console.ReadLine();
        Console.Write("Enter price:");
        decimal.TryParse(Console.ReadLine(), out _price.Value);
        Console.Write("Enter currency (UAH - 1, USD - 2, EUR - 3):");
        _price.Currency = (Currency)Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter weight:");
        double.TryParse(Console.ReadLine(), out _weight.Value);
        Console.Write("Enter weight unit (Gram - 1, Kilo - 2):");
        Console.WriteLine();
    }

    public override string ToString() 
        => $"Name: {_name}\tprice: {_price.Value} {_price.Currency}\t" +
           $"weight: {_weight.Value} {_weight.WeightUnit}";

    public object Clone() => new Product(_name, _price.Value, _price.Currency, _weight.Value, _weight.WeightUnit);

    public int CompareTo(object? obj) => _price.CompareTo(((Product)obj).Price);

    public override bool Equals(object? obj) => _name == ((Product)obj).Name && 
                                                _price == ((Product)obj).Price &&
                                                _weight == ((Product)obj).Weight;

    public override int GetHashCode() => HashCode.Combine(_name, _price, _weight);

    public Product(string name, decimal price, Currency currency, double weight, WeightUnit weightUnit)
    {
        Name = name;
        Price = (price, currency);
        Weight = (weight, weightUnit);
    }
    
    public Product() { }
}