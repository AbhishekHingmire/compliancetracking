using Microsoft.Extensions.Logging;
using RegWatch.Core.DTOs;
using RegWatch.Core.Interfaces;
namespace RegWatch.Infrastructure.Services;
public class ReportService : IReportService
{
    private readonly ILogger<ReportService> _logger;
    public ReportService(ILogger<ReportService> logger) => _logger = logger;

    public Task<MonthlyReportDto> GetMonthlyReportAsync(int tenantId, int year, int month, CancellationToken ct = default)
    {
        _logger.LogInformation("GetMonthlyReport called for tenant {TenantId}", tenantId);
        return Task.FromResult(new MonthlyReportDto(
            System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month),
            year, 0, 0, 0, 0, 0, new List<BodyBreakdownDto>(), new List<string>()
        ));
    }
}
