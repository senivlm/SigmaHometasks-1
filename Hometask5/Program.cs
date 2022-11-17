using Hometask1;
using Hometask1.Enums;
using Hometask5;
// ваші бали 94	95	95	90	95
// Прибрати всі консольні друки з модельних класів
var products = new List<Product>
{
    new ("Carrot", 2, Currency.USD, 5, WeightUnit.Kilo),
    new ("Banana", 5, Currency.EUR, 7, WeightUnit.Kilo),
    new ("Potato", 5, Currency.UAH, 7, WeightUnit.Kilo),
    new ("Banana", 5, Currency.UAH, 7, WeightUnit.Kilo),
    new ("Cola", 1, Currency.USD, 1, WeightUnit.Kilo),
    new ("Cheese", 200, Currency.UAH, 500, WeightUnit.Gram)
};

var buy = new Buy(products[0], 5);
var buy2 = new Buy(products[2], 1);
var buy3 = new Buy(products[4], 2);
var buy4 = new Buy(products[1], 7);

var basket = new Basket(buy, buy2, buy3, buy4);
Console.WriteLine(basket.ToString());
