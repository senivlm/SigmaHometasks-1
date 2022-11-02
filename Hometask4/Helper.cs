namespace Hometask4;

public static class Helper
{
    public static bool IsPrime(int number) => 
        number > 1 
        ? Enumerable.Range(1, number)
                    .Where(x => number % x == 0)
                    .SequenceEqual(new[] { 1, number }) 
        : false;
    
    public static void Output(IEnumerable<int> numbers)
    {
        foreach (var item in numbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}