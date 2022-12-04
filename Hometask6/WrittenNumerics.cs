namespace Hometask6;

public static class WrittenNumerics
{
    static readonly string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    static readonly string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static readonly string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    static readonly string[] thousandsGroups = { "", " Thousand", " Million", " Billion" };

    private static string FriendlyInteger(int n, string leftDigits, int thousands)
    {
        if (n == 0) return leftDigits;
        string friendlyInt = leftDigits;
        
        if (friendlyInt.Length > 0) friendlyInt += " ";

        friendlyInt += n switch
        {
            < 10 => ones[n],
            < 20 => teens[n - 10],
            < 100 => FriendlyInteger(n % 10, tens[n / 10 - 2], 0),
            < 1000 => FriendlyInteger(n % 100, (ones[n / 100] + " Hundred"), 0),
            _ => FriendlyInteger(n % 1000, FriendlyInteger(n / 1000, "", thousands + 1), 0)
        };

        return friendlyInt + thousandsGroups[thousands];
    }

    public static string ToWrittenDateOnly(this DateOnly date) =>
        $"{IntegerToWritten(date.Day)} {date:MMMM} {IntegerToWritten(date.Year)}";

    private static string IntegerToWritten(int n) => n switch
    {
        0 => "Zero",
        < 0 => "Negative " + IntegerToWritten(-n),
        _ => FriendlyInteger(n, "", 0)
    };
}