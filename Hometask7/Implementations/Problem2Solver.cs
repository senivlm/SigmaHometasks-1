using System.Text.RegularExpressions;
using Hometask2.Interfaces;
using Hometask7.Enums;

namespace Hometask7.Implementations;

public class Problem2Solver : IProblemSolver
{
    private bool LuhnAlghorithm(string cardNumber)
    {
        int sum = 0;
        bool alternate = false;
        
        for (int i = cardNumber.Length - 1; i >= 0; i--)
        {
            var nx = cardNumber.ToArray();
            // тут уже буде не коректна робота, якщо прийде довільна стрічка.
            var n = int.Parse(nx[i].ToString());

            if (alternate)
            {
                n *= 2;
                if (n > 9)
                {
                    n = (n % 10) + 1;
                }
            }
            sum += n;
            alternate = !alternate;
        }
        
        return (sum % 10 == 0);
    }
    
    private CardType FindCardType(string cardNumber)
    {// покажемо для групи регулярні вирази.
        if (Regex.Match(cardNumber, @"^4[0-9]{12}(?:[0-9]{3})?$").Success)
        {
            return CardType.Visa;
        }

        if (Regex.Match(cardNumber, @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$").Success)
        {
            return CardType.MasterCard;
        }

        if (Regex.Match(cardNumber, @"^3[47][0-9]{13}$").Success)
        {
            return CardType.AmericanExpress;
        }

        return CardType.Unknown;
    }
    
    public void Solve()
    {
        Console.WriteLine("Problem 2");
        
        var tests = new List<string>
        {
            "4003789100205381",
            "374198631295318",
            "5260215288993940",
            "375719380198699",
            "4539136898145051"
        };

        foreach (var item in tests)
        {
            var result = LuhnAlghorithm(item);
            Console.WriteLine($"Card number: {item} is valid: {result}");
            if(result) Console.WriteLine($"Card type: {FindCardType(item)}");
        }
    }
}
