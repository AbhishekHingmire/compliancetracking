namespace RegWatch.Core.DTOs;
public record InvoiceDto(int Id, string InvoiceNumber, DateTime Date, decimal Amount, string Status, string? InvoiceUrl);
public record BillingInfoDto(string CurrentPlan, decimal MonthlyAmount, string? CardLast4, DateTime? NextBillingDate, List<InvoiceDto> Invoices);
public record UpgradePlanDto(int TenantId, string NewPlan, string? RazorpayPaymentId);
