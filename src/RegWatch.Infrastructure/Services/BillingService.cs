using Microsoft.Extensions.Logging;
using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
using RegWatch.Core.Interfaces;
namespace RegWatch.Infrastructure.Services;
public class BillingService : IBillingService
{
    private readonly ILogger<BillingService> _logger;
    public BillingService(ILogger<BillingService> logger) => _logger = logger;

    public Task<BillingInfoDto> GetBillingInfoAsync(int tenantId, CancellationToken ct = default)
    {
        _logger.LogInformation("GetBillingInfo called for tenant {TenantId}", tenantId);
        return Task.FromResult(new BillingInfoDto("Free", 0, null, null, new List<InvoiceDto>()));
    }
    public Task<ServiceResult> UpgradePlanAsync(UpgradePlanDto request, CancellationToken ct = default)
    {
        _logger.LogInformation("UpgradePlan called for tenant {TenantId} to {Plan}", request.TenantId, request.NewPlan);
        // TODO: integrate with Razorpay
        return Task.FromResult(ServiceResult.Ok());
    }
    public Task<ServiceResult> CancelSubscriptionAsync(int tenantId, CancellationToken ct = default)
        => Task.FromResult(ServiceResult.Ok());
}
