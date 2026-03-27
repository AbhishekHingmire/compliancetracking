namespace RegWatch.Web.Models.Entities;

public class Invoice
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
    public int SubscriptionId { get; set; }
    public Subscription Subscription { get; set; } = null!;
    public string? RazorpayPaymentId { get; set; }
    public decimal Amount { get; set; }
    public string? Status { get; set; }
    public string? InvoiceUrl { get; set; }
    public DateTime? PaidAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
