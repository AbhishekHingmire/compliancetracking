namespace RegWatch.Core.Entities;

public class Tenant
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string? BusinessType { get; set; }
    public string? Industry { get; set; }
    public string? TurnoverSlab { get; set; }
    public string? EmployeeCount { get; set; }
    public string? State { get; set; }
    public string? Registrations { get; set; } // JSON array
    public string Plan { get; set; } = "free";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
    public ICollection<User> Users { get; set; } = new List<User>();
    public ICollection<Alert> Alerts { get; set; } = new List<Alert>();
    public ICollection<Deadline> Deadlines { get; set; } = new List<Deadline>();
    public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
