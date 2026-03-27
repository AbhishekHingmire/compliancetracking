using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Core.Interfaces;
namespace RegWatch.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
[Authorize]
public class AlertsController : ControllerBase
{
    private readonly IAlertService _alerts;
    public AlertsController(IAlertService alerts) => _alerts = alerts;

    [HttpGet]
    public async Task<IActionResult> GetAlerts([FromQuery] string? search, [FromQuery] string? priority, [FromQuery] string? body, [FromQuery] int page = 1, [FromQuery] int pageSize = 20, CancellationToken ct = default)
    {
        var tenantId = 1; // TODO: resolve from JWT claim
        var result = await _alerts.GetAlertsAsync(tenantId, search, priority, body, page, pageSize, ct);
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetAlert(int id, CancellationToken ct = default)
    {
        var tenantId = 1; // TODO: resolve from JWT claim
        var result = await _alerts.GetAlertDetailAsync(tenantId, id, ct);
        if (result is null) return NotFound();
        return Ok(result);
    }

    [HttpPost("{id:int}/read")]
    public async Task<IActionResult> MarkRead(int id, CancellationToken ct = default)
    {
        var tenantId = 1;
        var result = await _alerts.MarkAsReadAsync(tenantId, id, ct);
        return result.Success ? Ok() : BadRequest(result.Error);
    }

    [HttpPost("{id:int}/action")]
    public async Task<IActionResult> MarkActioned(int id, CancellationToken ct = default)
    {
        var tenantId = 1;
        var result = await _alerts.MarkAsActionedAsync(tenantId, id, ct);
        return result.Success ? Ok() : BadRequest(result.Error);
    }
}
