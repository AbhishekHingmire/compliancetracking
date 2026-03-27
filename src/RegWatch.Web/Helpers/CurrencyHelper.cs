namespace RegWatch.Web.Helpers;
public static class CurrencyHelper
{
    public static string FormatInr(decimal amount)
    {
        if (amount >= 10_000_000) return $"₹{amount / 10_000_000:0.##} Cr";
        if (amount >= 100_000) return $"₹{amount / 100_000:0.##} L";
        if (amount >= 1_000) return $"₹{amount / 1_000:0.##}K";
        return $"₹{amount:0}";
    }
    public static string FormatFull(decimal amount) => $"₹{amount:N0}";
}
