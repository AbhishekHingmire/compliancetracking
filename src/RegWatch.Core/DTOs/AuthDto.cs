namespace RegWatch.Core.DTOs;
public record LoginRequestDto(string Email, string Password, bool RememberMe);
public record RegisterRequestDto(string Name, string CompanyName, string Email, string? Phone, string Password);
public record AuthResponseDto(bool Success, string? Token, string? Error, int? UserId, string? Name);
