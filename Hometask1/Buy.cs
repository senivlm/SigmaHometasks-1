namespace Hometask1;

public class Buy
{
    private IEnumerable<Product> _products;
    public IEnumerable<Product> Products
    {
        get => new List<Product>(_products);
        init => _products = value;
    }

    public Buy(IEnumerable<Product> products) => 
        Products = products ?? throw new NullReferenceException();

    public override bool Equals(object? obj) =>
        _products.OrderBy(t => t.Name)
                 .SequenceEqual(((Buy)obj)
                     .Products.OrderBy(t => t.Name));

    public override string ToString() => 
        String.Join("", Products.Select(t => t.ToString() + "\tcount: " + Products.Count(x => x.Name == t.Name) + '\n').Distinct());
}