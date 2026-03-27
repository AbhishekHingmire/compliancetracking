namespace RegWatch.Web.Models.ViewModels;

public class OnboardingViewModel
{
    public int Step { get; set; } = 1;
    public string CompanyName { get; set; } = string.Empty;
    public string? BusinessType { get; set; }
    public string? Industry { get; set; }
    public string? TurnoverSlab { get; set; }
    public string? EmployeeCount { get; set; }
    public string? State { get; set; }
    public List<string> Registrations { get; set; } = new();
    public bool EmailNotifications { get; set; } = true;
    public bool WhatsappNotifications { get; set; }
    public string? Phone { get; set; }
}
