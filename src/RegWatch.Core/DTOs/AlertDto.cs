namespace RegWatch.Core.DTOs;
public record AlertDto(
    int Id,
    string Title,
    string? Priority,
    string Status,
    string RegulatoryBodyName,
    string? ImpactSummary,
    decimal? EstimatedSaving,
    DateTime CreatedAt
);
public record AlertDetailDto(
    int Id,
    string Title,
    string? Priority,
    string Status,
    string RegulatoryBodyName,
    string? SummaryEn,
    string? SummaryHi,
    string? ActionItems,
    string? PenaltyInfo,
    string? NotificationNumber,
    string? SourceUrl,
    string? PdfUrl,
    DateTime? EffectiveDate,
    DateTime? PublishedAt,
    decimal? EstimatedSaving
);
public record CreateAlertDto(int TenantId, int RegulationId, string? Priority);
