using Microsoft.Extensions.Logging;
using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
using RegWatch.Core.Interfaces;
namespace RegWatch.Infrastructure.Services;
public class AlertService : IAlertService
{
    private readonly ILogger<AlertService> _logger;
    public AlertService(ILogger<AlertService> logger) => _logger = logger;

    public Task<PagedResult<AlertDto>> GetAlertsAsync(int tenantId, string? search, string? priority, string? body, int page, int pageSize, CancellationToken ct = default)
    {
        // TODO: implement with EF Core query
        _logger.LogInformation("GetAlerts called for tenant {TenantId}", tenantId);
        return Task.FromResult(new PagedResult<AlertDto> { Page = page, PageSize = pageSize });
    }
    public Task<AlertDetailDto?> GetAlertDetailAsync(int tenantId, int alertId, CancellationToken ct = default)
    {
        _logger.LogInformation("GetAlertDetail called for alert {AlertId}", alertId);
        return Task.FromResult<AlertDetailDto?>(null);
    }
    public Task<ServiceResult> MarkAsReadAsync(int tenantId, int alertId, CancellationToken ct = default)
    {
        _logger.LogInformation("MarkAsRead called for alert {AlertId}", alertId);
        return Task.FromResult(ServiceResult.Ok());
    }
    public Task<ServiceResult> MarkAsActionedAsync(int tenantId, int alertId, CancellationToken ct = default)
    {
        _logger.LogInformation("MarkAsActioned called for alert {AlertId}", alertId);
        return Task.FromResult(ServiceResult.Ok());
    }
    public Task<int> GetUnreadCountAsync(int tenantId, CancellationToken ct = default)
        => Task.FromResult(0);
}
