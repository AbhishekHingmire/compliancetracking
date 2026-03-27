using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
namespace RegWatch.Core.Interfaces;
public interface IAlertService
{
    Task<PagedResult<AlertDto>> GetAlertsAsync(int tenantId, string? search, string? priority, string? body, int page, int pageSize, CancellationToken ct = default);
    Task<AlertDetailDto?> GetAlertDetailAsync(int tenantId, int alertId, CancellationToken ct = default);
    Task<ServiceResult> MarkAsReadAsync(int tenantId, int alertId, CancellationToken ct = default);
    Task<ServiceResult> MarkAsActionedAsync(int tenantId, int alertId, CancellationToken ct = default);
    Task<int> GetUnreadCountAsync(int tenantId, CancellationToken ct = default);
}
