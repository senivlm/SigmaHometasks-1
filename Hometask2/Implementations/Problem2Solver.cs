using Hometask2.Interfaces;

namespace Hometask2.Implementations;

public class Problem2Solver : IProblemSolver
{
    private void OutputNumberMatrix(int[,] matrix, string title = " ")
    {
        Console.WriteLine(title);
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}\t", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
// Приємно, що наочно!
    private void OutputColorMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.BackgroundColor = (ConsoleColor)matrix[row, col];
                Console.Write("   ");
            }
            Console.WriteLine();
            Console.BackgroundColor = 0;
        }
    }
    
    private void GetLongestSequence(IReadOnlyList<int> arr, ref int startIndex, ref int endIndex, 
                                    ref int sequenceNumber, ref int sequenceCount)
    {
        int tempCount = 1;

        for (int i = 0; i < arr.Count - 1; i++)
        {
            if (arr[i] == arr[i + 1]) tempCount++;
            else tempCount = 1;//Тут загубили потрібну довжину

            if (tempCount <= sequenceCount) continue;
            sequenceCount = tempCount;
            sequenceNumber = arr[i];
            endIndex = i;
        }
    
        startIndex = endIndex - sequenceCount + 2;
        endIndex += 1;
    }
    
    public void Solve()
    {
        Console.WriteLine("Problem 2");
        
        var matrix = new int[,]
        {
            { 1, 2, 3, 4, 5, 12, 13, 12, 12 },
            { 2, 1, 5, 10, 2, 1, 2, 9, 10 },
            { 3, 1, 7, 1, 1, 1, 1, 1, 1 }
        };
        
        OutputNumberMatrix(matrix, "Example matrix for problem solve illustration: ");
        OutputColorMatrix(matrix);

        var intermediateResults = new dynamic[matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            var temp = new List<int>();
        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp.Add(matrix[i, j]);
            }

            int startIndex = 0, endIndex = 0, sequenceNumber = 0, sequenceCount = 0;
            GetLongestSequence(temp, ref startIndex, ref endIndex, ref sequenceNumber, ref sequenceCount);
            intermediateResults[i] = new { startIndex, endIndex, sequenceNumber, sequenceCount };
        }

        var result = intermediateResults.MaxBy(t => t.sequenceCount);
        var ordinateIndex = intermediateResults.ToList().IndexOf(result);
        Console.BackgroundColor = (ConsoleColor)result.sequenceNumber;
        Console.Write("\n\n  ");
        Console.BackgroundColor = 0;
        Console.WriteLine($" Max sequence number: {result.sequenceNumber}");
        Console.WriteLine($"| count:\t{result.sequenceCount} " +
                          $"| startIndex:\t{result.startIndex} " +
                          $"| endIndex:\t{result.endIndex} " +
                          $"| ordinateIndex:\t{ordinateIndex}");
    }
}
