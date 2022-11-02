using Hometask1;
using Hometask3.Enums;
using Type = Hometask3.Enums.Type;

namespace Hometask3.Classes;

public class Meat : Product
{
    private Category Category { get; set; }
    private Type Type { get; set; }

    public override void ChangePrice(decimal percents)
    {
        base.ChangePrice(percents);

        if (Category.Equals(Category.PrimaryVariety))
        {
            Price += Price * 100 / Constraints.PrimarySortPercentage;
            return;
        }

        Price += Price * 100 / Constraints.SecondarySortPercentage;
    }
    
    public override void ConsoleInput()
    {
        Console.WriteLine("Meat product: ");
        base.ConsoleInput();
        Console.Write("Input meat type: ");
        Type = (Type)Convert.ToInt32(Console.ReadLine());
        Console.Write("Input meat category: ");
        Category = (Category)Convert.ToInt32(Console.ReadLine());
    }

    public override bool Equals(object? obj) => base.Equals(obj) && 
                                                Category.Equals(((Meat)obj).Category) && 
                                                Type.Equals(((Meat)obj).Type);

    public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), (int)Category, (int)Type);

    public override string ToString() => base.ToString() + $"\tcategory: {Category}\ttype: {Type}";
    
    public Meat() { }
    
    public Meat(string name, decimal price, double weight, Category category, Type type) 
        : base(name, price, weight)
    {
        Category = category;
        Type = type;
    }
}