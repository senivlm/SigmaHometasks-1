using Hometask1.Enums;

namespace Hometask1;

public class Buy
{
    private Product _product;
    public uint Amount { get; set; }

    public Product Product
    {
        get => _product;
        set => _product = new (value.Name, value.Price, value.Currency, value.Weight);
    }

    public override string ToString() => $"Product {_product.ToString()}\tAmount: {Amount}";

    public override bool Equals(object? obj) => _product.Name == ((Buy)obj).Product.Name && 
                                                Amount == ((Buy)obj).Amount;

    public Buy(Product product, uint amount)
    {
        Product = product;
        Amount = amount;
    }
}