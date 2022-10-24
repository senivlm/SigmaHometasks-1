using System.Data;

namespace Hometask2;

public class MatrixBuilder
{
    private readonly int[,] _matrix;
    private readonly (int, int) _size;

    public MatrixBuilder(int[,] matrix)
    {
        _matrix = matrix;
        _size = (matrix.GetLength(0), matrix.GetLength(1));
    }

    private void Reset()
    {
        for (int row = 0; row < _size.Item1; row++)
        {
            for (int col = 0; col < _size.Item2; col++)
            {
                _matrix[row, col] = 0;
            }
        }
    }

    public void Output(string title = " ")
    {
        Console.WriteLine(new string('-', _size.Item2 * 10));
        Console.WriteLine(title);
        Console.WriteLine(new string('-', _size.Item2 * 10));
        
        for (int row = 0; row < _size.Item1; row++)
        {
            for (int col = 0; col < _size.Item2; col++)
            {
                Console.Write("{0}\t", _matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', _size.Item2 * 10) + '\n');
    }

    public void VerticalSnakeFill()
    {
        var iterator = 1;
        
        for (int j = 0; j < _size.Item2; j++, iterator += _size.Item1)
        {
            for (int i = 0; i < _size.Item1; i++)
            {
                _matrix[i, j] = iterator;
                if (j % 2 == 0 && i != _size.Item1 - 1)
                {
                    iterator++;
                    continue;
                }
                
                if (j % 2 == 1 && i != _size.Item1 - 1)
                {
                    iterator--;
                }
            }
        }
    }

    public void DiagonalSnakeFill()
    {
        if (!_size.Item1.Equals(_size.Item2))
        {
            Reset();
            Console.WriteLine("Row`s and column`s count is not equal");
            return;
        }
        
        var iterator = 1;

        for (int diff = 1 - _size.Item1; diff <= _size.Item1 - 1; diff++)
        {
            for (int i = 0; i < _size.Item1; i++)
            {
                int j = i - diff;

                if (j < 0 || j >= _size.Item1)
                {
                    continue;
                }

                if (((diff + _size.Item1 + 1) & 1) > 0)
                {
                    _matrix[i, _size.Item1 - 1 - j] = iterator++;
                    continue;
                }

                _matrix[_size.Item1 - 1 - j, i] = iterator++;
            }
        }
    }

    public void SpiralSnakeFill()
    {
        var iterator = 1;
        var i = 0;
        var j = 0;
        
        for (int c = 0; iterator <= _size.Item2 * _size.Item1; c++)
        {
            for (; i < _size.Item1 - c; i++, iterator++)
            {
                _matrix[i, j] = iterator;
            }
            i--; j++;
            for (; j < _size.Item2 - c; j++, iterator++)
            {
                _matrix[i, j] = iterator;
            }
            i--; j--; 
            for (; i >= 0 + c; i--, iterator++)
            {
                _matrix[i, j] = iterator;
            }
            i++; j--;
            for (; j >= 1 + c; j--, iterator++)
            {
                _matrix[i, j] = iterator;
            }
            i++; j++; 
        }
    }
}