using Hometask1;
using Hometask1.Enums;
using Hometask3.Classes;
using Hometask3.Enums;
using Type = Hometask3.Enums.Type;

var storage = new Storage();
storage.ConsoleInit();
Console.WriteLine("Storage #1");
storage.Output();

var storage2 = new Storage(
    new Product("Cola", 23, Currency.UAH, 500), 
    new Meat("Globyno", 200, Currency.UAH, 200, Category.SecondaryVariety, Type.Beef), 
    new DairyProduct("Milk", 300, Currency.UAH, 300, 14));

Console.WriteLine("\n\nStorage #2");
//storage2.Output();
var allMeatProducts = storage2.GetAllMeatProducts();
Console.WriteLine("\n\nAll meat products in storage #2");
foreach (var item in allMeatProducts)
{
    Console.WriteLine(item);
}