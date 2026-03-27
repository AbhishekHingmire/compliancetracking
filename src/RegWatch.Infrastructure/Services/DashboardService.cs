using Microsoft.Extensions.Logging;
using RegWatch.Core.DTOs;
using RegWatch.Core.Interfaces;
namespace RegWatch.Infrastructure.Services;
public class DashboardService : IDashboardService
{
    private readonly ILogger<DashboardService> _logger;
    public DashboardService(ILogger<DashboardService> logger) => _logger = logger;

    public Task<DashboardStatsDto> GetStatsAsync(int tenantId, CancellationToken ct = default)
    {
        _logger.LogInformation("GetStats called for tenant {TenantId}", tenantId);
        return Task.FromResult(new DashboardStatsDto(0, 0, 0, 0, 0));
    }
    public Task<List<AlertDto>> GetRecentAlertsAsync(int tenantId, int count = 5, CancellationToken ct = default)
        => Task.FromResult(new List<AlertDto>());
    public Task<List<DeadlineDto>> GetUpcomingDeadlinesAsync(int tenantId, int count = 5, CancellationToken ct = default)
        => Task.FromResult(new List<DeadlineDto>());
    public Task<List<int>> GetWeeklyActivityAsync(int tenantId, CancellationToken ct = default)
        => Task.FromResult(new List<int> { 0, 0, 0, 0, 0, 0, 0 });
}
