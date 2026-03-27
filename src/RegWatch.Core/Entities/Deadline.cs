namespace RegWatch.Core.Entities;

public class Deadline
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
    public int? RegulationId { get; set; }
    public Regulation? Regulation { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public bool IsRecurring { get; set; }
    public string? Recurrence { get; set; }
    public string Status { get; set; } = "pending";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
