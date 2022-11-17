namespace Hometask4;

public class NumbersSequence
{
    private List<int> _numbers;
    public List<int> Numbers => new (_numbers);
   // Це тільки результат одного з методів. його в поля не потрібно вносити.
    private Dictionary<int, int> _numbersFrequency;

    public void SetNumbersFrequency() => 
        _numbersFrequency = _numbers.GroupBy(t => t)
                                    .ToDictionary(t => t.Key, t => t.Count());

    public void OutputNumbersFrequencyTable()
    {
        foreach (var item in _numbersFrequency)
        {
            Console.WriteLine($"Number = {item.Key}, Frequency = {item.Value}");
        }
    }
    
    public (int,int) LongestSequence(List<int> nums)
    {//алгоритмічно не все враховано
        int pos = 0, bestPosition = 0, bestLength = 0, length = 1;
        for (int i = 0; i < nums.Count() - 1; i++)
        {// Навіщо 1 умова?
            if (nums[i] == nums[i + 1] && Helper.IsPrime(nums[i]))
            {
                length++;
                if (length > bestLength)
                {
                    bestLength = length;
                    bestPosition = pos;
                }
                continue;
            }
            length = 1;
            pos = i+1;
        }

        return (bestPosition, bestPosition + bestLength - 1);
    }
    
    public int this[int index]
    {
        get => _numbers[index];
        set => _numbers[index] = value;
    }

    public NumbersSequence()
    {
        var random = new Random();
        _numbers = Enumerable.Range(0, random.Next(10))
                             .Select(r => random.Next(10))
                             .ToList();
    }
    
    public NumbersSequence(params int[] numbers) => _numbers = new List<int>(numbers);
}
