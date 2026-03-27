using RegWatch.Core.DTOs;
namespace RegWatch.Core.Interfaces;
public interface IReportService
{
    Task<MonthlyReportDto> GetMonthlyReportAsync(int tenantId, int year, int month, CancellationToken ct = default);
}
