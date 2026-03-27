namespace RegWatch.Core.Entities;

public class NotificationPreference
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public bool EmailDigest { get; set; } = true;
    public TimeOnly DigestTime { get; set; } = new TimeOnly(8, 0);
    public bool EmailInstant { get; set; } = true;
    public bool WhatsappAlerts { get; set; }
    public string WaPriority { get; set; } = "high";
    public bool WeeklySummary { get; set; } = true;
    public int WeeklyDay { get; set; } = 1;
    public bool MonthlyReport { get; set; } = true;
    public string? BodiesFilter { get; set; } // JSON
}
