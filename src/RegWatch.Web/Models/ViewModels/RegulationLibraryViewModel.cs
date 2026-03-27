namespace RegWatch.Web.Models.ViewModels;

public class RegulationItemViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string RegulatoryBody { get; set; } = string.Empty;
    public string? Priority { get; set; }
    public DateTime? PublishedAt { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public string? SummaryEn { get; set; }
    public string[] Tags { get; set; } = Array.Empty<string>();
    public bool IsNew { get; set; }
}

public class RegulationLibraryViewModel
{
    public List<RegulationItemViewModel> Regulations { get; set; } = new();
    public string? SearchQuery { get; set; }
    public string? FilterBody { get; set; }
    public string? FilterPriority { get; set; }
    public string? FilterIndustry { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;
    public int TotalCount { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
}
