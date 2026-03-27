namespace RegWatch.Web.Models.ViewModels;

public class AlertListViewModel
{
    public List<AlertItemViewModel> Alerts { get; set; } = new();
    public string? FilterBody { get; set; }
    public string? FilterPriority { get; set; }
    public string? FilterDate { get; set; }
    public string? SearchQuery { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;
    public int TotalCount { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
}
