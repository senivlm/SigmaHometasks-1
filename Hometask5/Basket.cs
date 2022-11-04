using Hometask1;

namespace Hometask5;

public class Basket
{
    private List<Buy> _buys;
    public List<Buy> Buys
    {
        get => new List<Buy>(_buys);
        set
        {
            var currency = value.First().Product.Price.Currency;
            bool condition = value.All(t => t.Product.Price.Currency == currency);
            if (condition)
            {
                _buys = value;
                return;
            }
            Console.WriteLine("All currencies should be the same");
        }
    }

    public Basket(List<Buy> buys) => _buys = buys;
    public Basket(params Buy[] buys) => _buys = buys.ToList();
    public Basket() => _buys = new List<Buy>();

    public void Add(Buy buy)
    {
        if (_buys.Count() == 0)
        {
            _buys.Add(buy);
            return;
        }
        
        var currency = _buys.First().Product.Price.Currency;
        if (currency != buy.Product.Price.Currency)
        {
            Console.WriteLine($"Currency of this basket is: {currency}");
            return;
        }
        
        _buys.Add(buy);
    }

    public override bool Equals(object? obj) =>
        _buys.OrderBy(t => t.Product.Name)
             .SequenceEqual(((Basket)obj)
             .Buys.OrderBy(t => t.Product.Name));

    public override string ToString() => string.Join("\n", _buys.Select(t => t.ToString()));
}