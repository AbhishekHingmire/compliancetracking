namespace RegWatch.Web.Models.Entities;

public class ScrapeLog
{
    public int Id { get; set; }
    public int RegulatoryBodyId { get; set; }
    public RegulatoryBody RegulatoryBody { get; set; } = null!;
    public string? Status { get; set; }
    public int ItemsFound { get; set; }
    public int NewItems { get; set; }
    public int? DurationMs { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime ScrapedAt { get; set; } = DateTime.UtcNow;
}
