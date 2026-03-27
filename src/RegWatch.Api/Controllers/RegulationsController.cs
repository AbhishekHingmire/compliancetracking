using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Core.Interfaces;
namespace RegWatch.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
[Authorize]
public class RegulationsController : ControllerBase
{
    private readonly IRegulationService _regulations;
    public RegulationsController(IRegulationService regulations) => _regulations = regulations;

    [HttpGet]
    public async Task<IActionResult> GetRegulations([FromQuery] string? search, [FromQuery] string? body, [FromQuery] string? priority, [FromQuery] string? industry, [FromQuery] int page = 1, [FromQuery] int pageSize = 20, CancellationToken ct = default)
    {
        var result = await _regulations.GetRegulationsAsync(search, body, priority, industry, page, pageSize, ct);
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetRegulation(int id, CancellationToken ct = default)
    {
        var result = await _regulations.GetByIdAsync(id, ct);
        if (result is null) return NotFound();
        return Ok(result);
    }
}
