using RegWatch.Core.Common;
using RegWatch.Core.Entities;
namespace RegWatch.Core.Interfaces;
public interface ITenantService
{
    Task<Tenant?> GetByIdAsync(int tenantId, CancellationToken ct = default);
    Task<ServiceResult> UpdateProfileAsync(int tenantId, string companyName, string? businessType, string? industry, string? state, string? registrations, CancellationToken ct = default);
}
