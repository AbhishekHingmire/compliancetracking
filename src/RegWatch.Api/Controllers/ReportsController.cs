using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Core.Interfaces;
namespace RegWatch.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
[Authorize]
public class ReportsController : ControllerBase
{
    private readonly IReportService _reports;
    public ReportsController(IReportService reports) => _reports = reports;

    [HttpGet("monthly")]
    public async Task<IActionResult> GetMonthlyReport([FromQuery] int? year, [FromQuery] int? month, CancellationToken ct = default)
    {
        var tenantId = 1;
        var now = DateTime.UtcNow;
        var result = await _reports.GetMonthlyReportAsync(tenantId, year ?? now.Year, month ?? now.Month, ct);
        return Ok(result);
    }
}
