namespace RegWatch.Core.Entities;

public class User
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string Role { get; set; } = "owner";
    public bool EmailVerified { get; set; }
    public string LanguagePref { get; set; } = "en";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public NotificationPreference? NotificationPreference { get; set; }
}
