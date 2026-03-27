namespace RegWatch.Core.DTOs;
public record BodyBreakdownDto(string Body, int AlertCount, int ActionedCount);
public record MonthlyReportDto(
    string Month, int Year, int TotalAlerts, int HighPriority,
    int Actioned, int Pending, decimal TotalSavings,
    List<BodyBreakdownDto> BodyBreakdown,
    List<string> PendingActions
);
