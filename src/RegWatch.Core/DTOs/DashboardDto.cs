namespace RegWatch.Core.DTOs;
public record DashboardStatsDto(
    int UrgentCount,
    int ThisMonthCount,
    int CompletedCount,
    int TotalCount,
    decimal EstimatedSavings
);
public record DeadlineDto(
    int Id,
    string Title,
    DateTime DueDate,
    string Status,
    bool IsRecurring
);
