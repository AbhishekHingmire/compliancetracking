using RegWatch.Core.Common;
using RegWatch.Core.Entities;
namespace RegWatch.Core.Interfaces;
public interface INotificationService
{
    Task<NotificationPreference?> GetPreferencesAsync(int userId, CancellationToken ct = default);
    Task<ServiceResult> UpdatePreferencesAsync(int userId, NotificationPreference preferences, CancellationToken ct = default);
    Task SendAlertEmailAsync(int userId, int alertId, CancellationToken ct = default);
    Task SendWhatsappAlertAsync(int userId, int alertId, CancellationToken ct = default);
}
