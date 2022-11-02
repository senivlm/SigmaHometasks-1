using Hometask1;
using Hometask3.Classes;
using Hometask4;

var storage = new Storage(
    new Product("Pepsi", 4, 300), 
    new Product("Fanta", 3, 250), 
    new Product("Coca-cola", 1, 500), 
    new Product("Schweppes", 2, 1000));

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