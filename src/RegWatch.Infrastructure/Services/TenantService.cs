using Microsoft.Extensions.Logging;
using RegWatch.Core.Common;
using RegWatch.Core.Entities;
using RegWatch.Core.Interfaces;
namespace RegWatch.Infrastructure.Services;
public class TenantService : ITenantService
{
    private readonly ILogger<TenantService> _logger;
    public TenantService(ILogger<TenantService> logger) => _logger = logger;

    public Task<Tenant?> GetByIdAsync(int tenantId, CancellationToken ct = default)
    {
        _logger.LogInformation("GetTenant called for {TenantId}", tenantId);
        return Task.FromResult<Tenant?>(null);
    }
    public Task<ServiceResult> UpdateProfileAsync(int tenantId, string companyName, string? businessType, string? industry, string? state, string? registrations, CancellationToken ct = default)
        => Task.FromResult(ServiceResult.Ok());
}
