﻿using Hometask1;
using Hometask1.Enums;

var testProduct = new Product("Schweppes", 30, Currency.UAH, 500);

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


Console.WriteLine("Check.GetBuyInfo(buy):");
Check.GetBuyInfo(buy);
Console.WriteLine("Check.GetProductInfo(testProduct):");
Check.GetProductInfo(testProduct);