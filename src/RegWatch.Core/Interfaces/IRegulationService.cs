using RegWatch.Core.Common;
using RegWatch.Core.DTOs;
namespace RegWatch.Core.Interfaces;
public interface IRegulationService
{
    Task<PagedResult<RegulationDto>> GetRegulationsAsync(string? search, string? body, string? priority, string? industry, int page, int pageSize, CancellationToken ct = default);
    Task<RegulationDto?> GetByIdAsync(int id, CancellationToken ct = default);
}
