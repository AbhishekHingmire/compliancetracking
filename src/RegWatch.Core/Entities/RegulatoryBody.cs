namespace RegWatch.Core.Entities;

public class RegulatoryBody
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? WebsiteUrl { get; set; }
    public string? ScrapeUrl { get; set; }
    public int ScrapeInterval { get; set; } = 120;
    public bool IsActive { get; set; } = true;
    public ICollection<Regulation> Regulations { get; set; } = new List<Regulation>();
    public ICollection<ScrapeLog> ScrapeLogs { get; set; } = new List<ScrapeLog>();
}
