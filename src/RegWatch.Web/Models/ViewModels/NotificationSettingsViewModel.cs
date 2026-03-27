namespace RegWatch.Web.Models.ViewModels;

public class NotificationSettingsViewModel
{
    public bool EmailDigest { get; set; } = true;
    public string DigestTime { get; set; } = "08:00";
    public bool EmailInstant { get; set; } = true;
    public bool WhatsappAlerts { get; set; }
    public string WaPriority { get; set; } = "high";
    public bool WeeklySummary { get; set; } = true;
    public int WeeklyDay { get; set; } = 1;
    public bool MonthlyReport { get; set; } = true;
    public List<string> BodiesFilter { get; set; } = new();
}
