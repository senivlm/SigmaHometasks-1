namespace Hometask1;

public class Buy
{
    private IEnumerable<Product> Products { get; }

    public Buy(IEnumerable<Product> products) => 
        Products = products ?? throw new NullReferenceException();

    public override string ToString() => 
        String.Join("", Products.Select(t => t.ToString() + "\tcount: " + Products.Count(x => x.Name == t.Name) + '\n').Distinct());
}