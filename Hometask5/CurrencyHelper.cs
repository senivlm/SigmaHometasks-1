using Hometask1.Enums;

namespace Hometask5;

public static class CurrencyHelper
{
    private const decimal EurUah = (decimal)36.2;
    private const decimal UsdUah = (decimal)36.9;

    public static decimal ConvertToUah(Currency currency, decimal value) =>
        currency == Currency.EUR ? EurUah * value : UsdUah * value;
}