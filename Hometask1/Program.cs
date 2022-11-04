using Hometask1;
using Hometask1.Enums;

var testProduct = new Product("Schweppes", 30, Currency.UAH, 500, WeightUnit.Gram);

var products = new List<Product>
{
    new ("Carrot", 10, Currency.UAH, 5, WeightUnit.Gram),
    new ("Banana", 5, Currency.UAH, 7, WeightUnit.Gram),
    new ("Banana", 5, Currency.UAH, 7, WeightUnit.Gram),
    new ("Banana", 5, Currency.UAH, 7, WeightUnit.Gram),
    new ("Cola", 15, Currency.UAH, 24.5, WeightUnit.Gram),
    new ("Cola", 15, Currency.UAH, 24.5, WeightUnit.Gram),
    new ("Cheese", 200, Currency.UAH, 1, WeightUnit.Kilo)
};

var buy = new Buy(products[0], 5);

Console.WriteLine("Check.GetBuyInfo(buy):");
Check.GetBuyInfo(buy);
Console.WriteLine("Check.GetProductInfo(testProduct):");
Check.GetProductInfo(testProduct);