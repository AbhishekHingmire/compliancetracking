namespace RegWatch.Web.Helpers;
public static class DateTimeHelper
{
    public static string ToRelative(DateTime dt)
    {
        var diff = DateTime.UtcNow - dt.ToUniversalTime();
        return diff.TotalMinutes < 1 ? "Just now"
             : diff.TotalHours < 1 ? $"{(int)diff.TotalMinutes}m ago"
             : diff.TotalDays < 1 ? $"{(int)diff.TotalHours}h ago"
             : diff.TotalDays < 7 ? $"{(int)diff.TotalDays}d ago"
             : dt.ToString("dd MMM yyyy");
    }
    public static string DaysRemainingLabel(DateTime dueDate)
    {
        var days = (dueDate.Date - DateTime.Today).Days;
        return days < 0 ? "Overdue" : days == 0 ? "Due today" : days == 1 ? "Tomorrow" : $"{days} days";
    }
    public static string DaysRemainingColor(DateTime dueDate)
    {
        var days = (dueDate.Date - DateTime.Today).Days;
        return days < 0 ? "danger" : days <= 3 ? "warning" : "success";
    }
    public static string FormatIndianDate(DateTime? dt) => dt?.ToString("dd MMM yyyy") ?? "—";
}
