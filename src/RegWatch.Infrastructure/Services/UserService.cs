using Microsoft.Extensions.Logging;
using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
using RegWatch.Core.Interfaces;
namespace RegWatch.Infrastructure.Services;
public class UserService : IUserService
{
    private readonly ILogger<UserService> _logger;
    public UserService(ILogger<UserService> logger) => _logger = logger;

    public Task<AuthResponseDto> LoginAsync(LoginRequestDto request, CancellationToken ct = default)
    {
        _logger.LogInformation("Login called for {Email}", request.Email);
        // TODO: verify credentials against DB with BCrypt
        return Task.FromResult(new AuthResponseDto(false, null, "Not implemented yet", null, null));
    }
    public Task<AuthResponseDto> RegisterAsync(RegisterRequestDto request, CancellationToken ct = default)
    {
        _logger.LogInformation("Register called for {Email}", request.Email);
        // TODO: create tenant + user, hash password with BCrypt
        return Task.FromResult(new AuthResponseDto(false, null, "Not implemented yet", null, null));
    }
    public Task<ServiceResult> UpdateProfileAsync(int userId, string name, string? phone, CancellationToken ct = default)
        => Task.FromResult(ServiceResult.Ok());
    public Task<ServiceResult> ChangePasswordAsync(int userId, string currentPassword, string newPassword, CancellationToken ct = default)
        => Task.FromResult(ServiceResult.Ok());
}
