namespace RegWatch.Web.Models.ViewModels;

public class AlertItemViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string Priority { get; set; } = "Medium";
    public string Status { get; set; } = "unread";
    public string RegulatoryBody { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public decimal? EstimatedSaving { get; set; }
    public string[] Tags { get; set; } = Array.Empty<string>();
}

public class DeadlineItemViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public string Status { get; set; } = "pending";
    public bool IsRecurring { get; set; }
    public int DaysRemaining => (DueDate - DateTime.Today).Days;
}

public class DashboardViewModel
{
    public int UrgentCount { get; set; }
    public int ThisMonthCount { get; set; }
    public int CompletedCount { get; set; }
    public int TotalCount { get; set; }
    public decimal EstimatedSavings { get; set; }
    public List<AlertItemViewModel> RecentAlerts { get; set; } = new();
    public List<DeadlineItemViewModel> UpcomingDeadlines { get; set; } = new();
    public List<int> WeeklyActivity { get; set; } = new();
}
