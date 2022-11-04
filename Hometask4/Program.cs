using Hometask1;
using Hometask1.Enums;
using Hometask3.Classes;
using Hometask4;

var storage = new Storage(
    new Product("Pepsi", 4, Currency.UAH, 300, WeightUnit.Gram), 
    new Product("Fanta", 3, Currency.UAH, 250, WeightUnit.Gram), 
    new Product("Coca-cola", 1, Currency.UAH, 500, WeightUnit.Gram), 
    new Product("Schweppes", 2, Currency.UAH, 1000, WeightUnit.Gram));

Console.WriteLine("\n\nStorage before sort:");
storage.Output();
Console.WriteLine("\n\nStorage after sort by price:");
storage.Sort();
storage.Output();

var numbersSequence = new NumbersSequence(2, 2, 2, 2, 77, 15, 12, 12, 12, 12, 12, 12, 0, 7, 7, 7, 7, 7, 7);
Console.WriteLine("\n\nSequence: ");
Helper.Output(numbersSequence.Numbers);
Console.WriteLine("\n\nNumbers frequency table:");
numbersSequence.SetNumbersFrequency();
numbersSequence.OutputNumbersFrequencyTable();
var longestSequenceIndexes = numbersSequence.LongestSequence(numbersSequence.Numbers);
var numbers2 = numbersSequence.Numbers; 
numbers2.RemoveRange(longestSequenceIndexes.Item1, longestSequenceIndexes.Item2 - longestSequenceIndexes.Item1 + 1);
var secondLongestSequenceIndexes = numbersSequence.LongestSequence(numbers2);
Console.WriteLine($"\n\nThe longest sequence of prime numbers: ");
Console.WriteLine($"Index: [{longestSequenceIndexes.Item1}, {longestSequenceIndexes.Item2}]");
Console.WriteLine($"\n\nThe second longest sequence of prime numbers: ");
Console.WriteLine($"Index: [{secondLongestSequenceIndexes.Item1}, {secondLongestSequenceIndexes.Item2}]");