namespace RegWatch.Web.Models.Entities;

public class Alert
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
    public int RegulationId { get; set; }
    public Regulation Regulation { get; set; } = null!;
    public string? Priority { get; set; }
    public string Status { get; set; } = "unread";
    public string? ImpactSummary { get; set; }
    public decimal? EstimatedSaving { get; set; }
    public bool NotifiedEmail { get; set; }
    public bool NotifiedWhatsapp { get; set; }
    public DateTime? ReadAt { get; set; }
    public DateTime? ActionedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
