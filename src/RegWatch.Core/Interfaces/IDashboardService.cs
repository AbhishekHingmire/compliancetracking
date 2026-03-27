using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
namespace RegWatch.Core.Interfaces;
public interface IDashboardService
{
    Task<DashboardStatsDto> GetStatsAsync(int tenantId, CancellationToken ct = default);
    Task<List<AlertDto>> GetRecentAlertsAsync(int tenantId, int count = 5, CancellationToken ct = default);
    Task<List<DeadlineDto>> GetUpcomingDeadlinesAsync(int tenantId, int count = 5, CancellationToken ct = default);
    Task<List<int>> GetWeeklyActivityAsync(int tenantId, CancellationToken ct = default);
}
