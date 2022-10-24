using Hometask2.Interfaces;

namespace Hometask2.Implementations;

public class Problem1Solver : IProblemSolver
{
    private (int, int) InputSize()
    {
        Console.Write("Enter rows count:\t");
        var rowsCount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter columns count:\t");
        var columnsCount = Convert.ToInt32(Console.ReadLine());

        return (rowsCount, columnsCount);
    }
    
    public void Solve()
    {
        Console.WriteLine("Problem 1");
        
        var matrixSize = InputSize();
        var matrix = new int[matrixSize.Item1, matrixSize.Item2];
        var matrixBuilder = new MatrixBuilder(matrix);

        matrixBuilder.VerticalSnakeFill();
        matrixBuilder.Output("matrixBuilder.VerticalSnakeFill()");

        matrixBuilder.DiagonalSnakeFill();
        matrixBuilder.Output("matrixBuilder.DiagonalSnakeFill()");

        matrixBuilder.SpiralSnakeFill();
        matrixBuilder.Output("matrixBuilder.SpiralSnakeFill()");
    }
}