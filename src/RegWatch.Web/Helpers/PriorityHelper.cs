namespace RegWatch.Web.Helpers;
public static class PriorityHelper
{
    public static string BadgeClass(string? priority) => priority?.ToLower() switch
    {
        "high" => "bg-red-100 text-red-700 border border-red-200",
        "medium" => "bg-amber-100 text-amber-700 border border-amber-200",
        "low" => "bg-green-100 text-green-700 border border-green-200",
        _ => "bg-gray-100 text-gray-600 border border-gray-200",
    };
    public static string DotClass(string? priority) => priority?.ToLower() switch
    {
        "high" => "bg-red-500",
        "medium" => "bg-amber-500",
        "low" => "bg-green-500",
        _ => "bg-gray-400",
    };
    public static string Icon(string? priority) => priority?.ToLower() switch
    {
        "high" => "alert-triangle",
        "medium" => "info",
        "low" => "check-circle",
        _ => "circle",
    };
}
