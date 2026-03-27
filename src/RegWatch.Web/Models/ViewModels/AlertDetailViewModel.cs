namespace RegWatch.Web.Models.ViewModels;

public class AlertDetailViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string Priority { get; set; } = "Medium";
    public string Status { get; set; } = "unread";
    public string[] Tags { get; set; } = Array.Empty<string>();
    public DateTime? PublishedDate { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public string SummaryEn { get; set; } = string.Empty;
    public string SummaryHi { get; set; } = string.Empty;
    public List<string> ActionItems { get; set; } = new();
    public string? PenaltyInfo { get; set; }
    public string RegulatoryBodyName { get; set; } = string.Empty;
    public string? NotificationNumber { get; set; }
    public string? OriginalDocumentUrl { get; set; }
    public string? PdfUrl { get; set; }
    // Impact section
    public decimal? CurrentAmount { get; set; }
    public decimal? NewAmount { get; set; }
    public decimal? Saving { get; set; }
    public bool IsEligible { get; set; }
    public List<AlertItemViewModel> RelatedAlerts { get; set; } = new();
}
