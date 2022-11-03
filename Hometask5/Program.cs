using Hometask1;
using Hometask1.Enums;
using Hometask5;

var products = new List<Product>
{
    new ("Carrot", 10, Currency.UAH, 5),
    new ("Banana", 5, Currency.UAH, 7),
    new ("Banana", 5, Currency.UAH, 7),
    new ("Banana", 5, Currency.UAH, 7),
    new ("Cola", 15, Currency.UAH, 24.5),
    new ("Cola", 15, Currency.UAH, 24.5),
    new ("Cheese", 200, Currency.UAH, 12)
};

var buy = new Buy(products[0], 5);
var buy2 = new Buy(products[2], 1);
var buy3 = new Buy(products[4], 2);
var buy4 = new Buy(products[1], 7);

var basket = new Basket(buy, buy2, buy3, buy4);
Console.WriteLine(basket.ToString());