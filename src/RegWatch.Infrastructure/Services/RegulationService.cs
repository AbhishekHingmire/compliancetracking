using Microsoft.Extensions.Logging;
using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
using RegWatch.Core.Interfaces;
namespace RegWatch.Infrastructure.Services;
public class RegulationService : IRegulationService
{
    private readonly ILogger<RegulationService> _logger;
    public RegulationService(ILogger<RegulationService> logger) => _logger = logger;

    public Task<PagedResult<RegulationDto>> GetRegulationsAsync(string? search, string? body, string? priority, string? industry, int page, int pageSize, CancellationToken ct = default)
    {
        _logger.LogInformation("GetRegulations called");
        return Task.FromResult(new PagedResult<RegulationDto> { Page = page, PageSize = pageSize });
    }
    public Task<RegulationDto?> GetByIdAsync(int id, CancellationToken ct = default)
        => Task.FromResult<RegulationDto?>(null);
}
