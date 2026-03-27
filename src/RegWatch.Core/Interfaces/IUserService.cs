using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
namespace RegWatch.Core.Interfaces;
public interface IUserService
{
    Task<AuthResponseDto> LoginAsync(LoginRequestDto request, CancellationToken ct = default);
    Task<AuthResponseDto> RegisterAsync(RegisterRequestDto request, CancellationToken ct = default);
    Task<ServiceResult> UpdateProfileAsync(int userId, string name, string? phone, CancellationToken ct = default);
    Task<ServiceResult> ChangePasswordAsync(int userId, string currentPassword, string newPassword, CancellationToken ct = default);
}
