namespace RegWatch.Web.Models.ViewModels;

public class InvoiceViewModel
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? InvoiceUrl { get; set; }
}

public class BillingViewModel
{
    public string CurrentPlan { get; set; } = "Free";
    public decimal MonthlyAmount { get; set; }
    public string? PaymentMethod { get; set; }
    public string? CardLast4 { get; set; }
    public DateTime? NextBillingDate { get; set; }
    public List<InvoiceViewModel> Invoices { get; set; } = new();
}
