namespace RegWatch.Web.Models.ViewModels;

public class BodyBreakdownViewModel
{
    public string Body { get; set; } = string.Empty;
    public int AlertCount { get; set; }
    public int ActionedCount { get; set; }
}

public class MonthlyReportViewModel
{
    public string Month { get; set; } = string.Empty;
    public int Year { get; set; }
    public int TotalAlerts { get; set; }
    public int HighPriority { get; set; }
    public int Actioned { get; set; }
    public int Pending { get; set; }
    public decimal TotalSavings { get; set; }
    public List<BodyBreakdownViewModel> BodyBreakdown { get; set; } = new();
    public List<string> PendingActions { get; set; } = new();
}
