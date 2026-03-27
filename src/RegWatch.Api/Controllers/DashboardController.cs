using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Core.Interfaces;
namespace RegWatch.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
[Authorize]
public class DashboardController : ControllerBase
{
    private readonly IDashboardService _dashboard;
    public DashboardController(IDashboardService dashboard) => _dashboard = dashboard;

    [HttpGet("stats")]
    public async Task<IActionResult> GetStats(CancellationToken ct = default)
    {
        var tenantId = 1;
        var stats = await _dashboard.GetStatsAsync(tenantId, ct);
        return Ok(stats);
    }

    [HttpGet("recent-alerts")]
    public async Task<IActionResult> GetRecentAlerts([FromQuery] int count = 5, CancellationToken ct = default)
    {
        var tenantId = 1;
        var alerts = await _dashboard.GetRecentAlertsAsync(tenantId, count, ct);
        return Ok(alerts);
    }

    [HttpGet("deadlines")]
    public async Task<IActionResult> GetDeadlines([FromQuery] int count = 5, CancellationToken ct = default)
    {
        var tenantId = 1;
        var deadlines = await _dashboard.GetUpcomingDeadlinesAsync(tenantId, count, ct);
        return Ok(deadlines);
    }
}
