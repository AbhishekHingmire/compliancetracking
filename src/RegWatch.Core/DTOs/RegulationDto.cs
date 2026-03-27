namespace RegWatch.Core.DTOs;
public record RegulationDto(
    int Id,
    string Title,
    string RegulatoryBodyName,
    string? Priority,
    string? SummaryEn,
    string? Tags,
    DateTime? PublishedAt,
    DateTime? EffectiveDate,
    bool IsPublished
);
