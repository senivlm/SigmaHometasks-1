using Hometask1;

var testProduct = new Product("Schweppes", 30, 500);
// Цей список краще огорнути класом.
var products = new List<Product>
{
    new ("Carrot", 10, 5),
    new ("Banana", 5, 7),
    new ("Banana", 5, 7),
    new ("Banana", 5, 7),
    new ("Cola", 15, 24.5),
    new ("Cola", 15, 24.5),
    new ("Cheese", 200, 12)
};

var buy = new Buy(products);
Console.WriteLine("Check.GetBuyInfo(buy):");
Check.GetBuyInfo(buy);
Console.WriteLine("Check.GetProductInfo(testProduct):");
Check.GetProductInfo(testProduct);
