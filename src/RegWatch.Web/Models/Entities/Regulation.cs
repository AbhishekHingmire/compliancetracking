namespace RegWatch.Web.Models.Entities;

public class Regulation
{
    public int Id { get; set; }
    public int RegulatoryBodyId { get; set; }
    public RegulatoryBody RegulatoryBody { get; set; } = null!;
    public string Title { get; set; } = string.Empty;
    public string? OriginalText { get; set; }
    public string? SummaryEn { get; set; }
    public string? SummaryHi { get; set; }
    public string? ActionItems { get; set; } // JSON
    public string? Priority { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public string? NotificationNumber { get; set; }
    public string? SourceUrl { get; set; }
    public string? PdfUrl { get; set; }
    public string? Tags { get; set; } // JSON
    public string? AffectedIndustries { get; set; } // JSON
    public string? AffectedTurnovers { get; set; } // JSON
    public string? AffectedStates { get; set; } // JSON
    public string? PenaltyInfo { get; set; }
    public string? SavingsEstimate { get; set; }
    public DateTime? PublishedAt { get; set; }
    public DateTime ScrapedAt { get; set; } = DateTime.UtcNow;
    public bool AiProcessed { get; set; }
    public bool IsPublished { get; set; }
    public ICollection<Alert> Alerts { get; set; } = new List<Alert>();
}
