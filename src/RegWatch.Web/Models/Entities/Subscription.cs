namespace RegWatch.Web.Models.Entities;

public class Subscription
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
    public string Plan { get; set; } = string.Empty;
    public string? RazorpaySubId { get; set; }
    public string? RazorpayCustomerId { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "INR";
    public string? Status { get; set; }
    public DateTime? CurrentPeriodStart { get; set; }
    public DateTime? CurrentPeriodEnd { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
