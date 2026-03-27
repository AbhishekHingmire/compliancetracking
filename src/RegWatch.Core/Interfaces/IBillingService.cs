using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
namespace RegWatch.Core.Interfaces;
public interface IBillingService
{
    Task<BillingInfoDto> GetBillingInfoAsync(int tenantId, CancellationToken ct = default);
    Task<ServiceResult> UpgradePlanAsync(UpgradePlanDto request, CancellationToken ct = default);
    Task<ServiceResult> CancelSubscriptionAsync(int tenantId, CancellationToken ct = default);
}
