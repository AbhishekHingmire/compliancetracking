namespace RegWatch.Web.Helpers;
public static class StringExtensions
{
    public static string Truncate(this string? value, int maxLength, string suffix = "…")
    {
        if (string.IsNullOrEmpty(value)) return string.Empty;
        return value.Length <= maxLength ? value : value[..maxLength] + suffix;
    }
    public static string ToInitials(this string name)
    {
        var parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return parts.Length >= 2
            ? $"{parts[0][0]}{parts[^1][0]}".ToUpper()
            : name.Length >= 2 ? name[..2].ToUpper() : name.ToUpper();
    }
    public static string[] ParseJsonArray(this string? json)
    {
        if (string.IsNullOrEmpty(json)) return Array.Empty<string>();
        try { return System.Text.Json.JsonSerializer.Deserialize<string[]>(json) ?? Array.Empty<string>(); }
        catch { return Array.Empty<string>(); }
    }
}
