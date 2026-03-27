using System.ComponentModel.DataAnnotations;

namespace RegWatch.Web.Models.ViewModels;

public class RegisterViewModel
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string CompanyName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public string? Phone { get; set; }

    [Required]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = string.Empty;
}
