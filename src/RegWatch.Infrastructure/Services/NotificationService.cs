using Microsoft.Extensions.Logging;
using RegWatch.Core.Common;
using RegWatch.Core.Entities;
using RegWatch.Core.Interfaces;
namespace RegWatch.Infrastructure.Services;
public class NotificationService : INotificationService
{
    private readonly ILogger<NotificationService> _logger;
    public NotificationService(ILogger<NotificationService> logger) => _logger = logger;

    public Task<NotificationPreference?> GetPreferencesAsync(int userId, CancellationToken ct = default)
        => Task.FromResult<NotificationPreference?>(null);
    public Task<ServiceResult> UpdatePreferencesAsync(int userId, NotificationPreference preferences, CancellationToken ct = default)
        => Task.FromResult(ServiceResult.Ok());
    public Task SendAlertEmailAsync(int userId, int alertId, CancellationToken ct = default)
    {
        _logger.LogInformation("TODO: send alert email to user {UserId} for alert {AlertId}", userId, alertId);
        return Task.CompletedTask;
    }
    public Task SendWhatsappAlertAsync(int userId, int alertId, CancellationToken ct = default)
    {
        _logger.LogInformation("TODO: send WhatsApp alert to user {UserId} for alert {AlertId}", userId, alertId);
        return Task.CompletedTask;
    }
}
