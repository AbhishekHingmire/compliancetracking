using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;

namespace RegWatch.Web.Controllers;

[Authorize]
public class AlertsController : Controller
{
    public IActionResult Index(string? search, string? priority, string? body, int page = 1)
    {
        ViewData["Title"] = "Alerts";
        var alerts = GetSampleAlerts();

        if (!string.IsNullOrWhiteSpace(search))
            alerts = alerts.Where(a => a.Title.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
        if (!string.IsNullOrWhiteSpace(priority))
            alerts = alerts.Where(a => a.Priority == priority).ToList();
        if (!string.IsNullOrWhiteSpace(body))
            alerts = alerts.Where(a => a.RegulatoryBody == body).ToList();

        var vm = new AlertListViewModel
        {
            Alerts = alerts.Skip((page - 1) * 20).Take(20).ToList(),
            SearchQuery = search,
            FilterPriority = priority,
            FilterBody = body,
            Page = page,
            PageSize = 20,
            TotalCount = alerts.Count
        };
        return View(vm);
    }

    public IActionResult Detail(int id)
    {
        ViewData["Title"] = "Alert Detail";
        var vm = new AlertDetailViewModel
        {
            Id = id,
            Title = "GST Rate Change on Synthetic Textile Products",
            Body = "CBIC has notified revised GST rates on synthetic textile products vide Notification No. 14/2024-Central Tax (Rate) effective 1 April 2024.",
            Priority = "High",
            Status = "unread",
            Tags = new[] { "GST", "Textile", "CBIC" },
            PublishedDate = DateTime.Now.AddDays(-2),
            EffectiveDate = DateTime.Today.AddMonths(1),
            SummaryEn = "The Central Board of Indirect Taxes and Customs (CBIC) has revised GST rates on synthetic textile products. Products in HS Code 5402 will attract 12% GST (up from 5%). This affects manufacturers and traders of synthetic yarn, fabrics and made-up articles.",
            SummaryHi = "केंद्रीय अप्रत्यक्ष कर और सीमा शुल्क बोर्ड (CBIC) ने सिंथेटिक टेक्सटाइल उत्पादों पर GST दरों को संशोधित किया है। HS कोड 5402 के उत्पादों पर अब 12% GST लगेगा (5% से बढ़ाया गया)।",
            ActionItems = new List<string>
            {
                "Update accounting software with new GST rates",
                "Revise purchase orders and invoices from April 1st",
                "Inform procurement team about rate changes",
                "File amended return if rate applied incorrectly",
                "Verify HSN codes for all textile products in catalogue",
            },
            PenaltyInfo = "Non-compliance may attract interest at 18% per annum plus penalty up to 100% of tax amount under Section 50 of CGST Act.",
            RegulatoryBodyName = "Central Board of Indirect Taxes and Customs (CBIC)",
            NotificationNumber = "14/2024-CT(R)",
            OriginalDocumentUrl = "https://cbic.gov.in/notification",
            PdfUrl = "https://cbic.gov.in/notification/pdf",
            CurrentAmount = 500000,
            NewAmount = 415000,
            Saving = 85000,
            IsEligible = true,
            RelatedAlerts = new List<AlertItemViewModel>
            {
                new() { Id = 5, Title = "HSN Code Mandatory for All B2B Invoices", Priority = "Medium", RegulatoryBody = "CBIC", CreatedAt = DateTime.Now.AddDays(-5) },
                new() { Id = 6, Title = "E-Invoice Threshold Reduced to ₹5 Cr", Priority = "High", RegulatoryBody = "CBIC", CreatedAt = DateTime.Now.AddDays(-10) },
            }
        };
        return View(vm);
    }

    private static List<AlertItemViewModel> GetSampleAlerts() => new()
    {
        new() { Id = 1, Title = "GST Rate Change on Textile Products", Body = "CBIC notified revised GST rates on synthetic textile products.", Priority = "High", Status = "unread", RegulatoryBody = "CBIC", CreatedAt = DateTime.Now.AddHours(-2), EstimatedSaving = 85000, Tags = new[] { "GST", "Textile" } },
        new() { Id = 2, Title = "PF Contribution Threshold Revised", Body = "EPFO revised salary threshold for mandatory PF contribution.", Priority = "High", Status = "unread", RegulatoryBody = "EPFO", CreatedAt = DateTime.Now.AddHours(-5), EstimatedSaving = 36000, Tags = new[] { "PF", "HR" } },
        new() { Id = 3, Title = "SEBI LODR Amendment — Board Composition", Body = "Listed entities must ensure at least one independent woman director.", Priority = "Medium", Status = "read", RegulatoryBody = "SEBI", CreatedAt = DateTime.Now.AddDays(-1), Tags = new[] { "SEBI", "Corporate" } },
        new() { Id = 4, Title = "Income Tax — New TDS Section 194BA", Body = "New TDS on winnings from online games at 30%.", Priority = "Medium", Status = "read", RegulatoryBody = "IT Dept", CreatedAt = DateTime.Now.AddDays(-2), Tags = new[] { "TDS", "Income Tax" } },
        new() { Id = 5, Title = "HSN Code Mandatory for All B2B Invoices", Body = "GST Council mandates 6-digit HSN on all B2B invoices from April.", Priority = "Medium", Status = "actioned", RegulatoryBody = "CBIC", CreatedAt = DateTime.Now.AddDays(-5), Tags = new[] { "GST", "Invoice" } },
        new() { Id = 6, Title = "E-Invoice Threshold Reduced to ₹5 Cr Turnover", Body = "E-invoicing mandatory for taxpayers with aggregate turnover ≥ ₹5 Cr.", Priority = "High", Status = "unread", RegulatoryBody = "CBIC", CreatedAt = DateTime.Now.AddDays(-7), EstimatedSaving = 45000, Tags = new[] { "E-Invoice", "GST" } },
        new() { Id = 7, Title = "FSSAI License Renewal Deadline Extension", Body = "FSSAI has extended license renewal deadline by 60 days.", Priority = "Low", Status = "read", RegulatoryBody = "FSSAI", CreatedAt = DateTime.Now.AddDays(-3), Tags = new[] { "Food", "License" } },
        new() { Id = 8, Title = "Labour Code Implementation Update", Body = "Ministry of Labour confirms implementation timeline for 4 labour codes.", Priority = "High", Status = "unread", RegulatoryBody = "DPIIT", CreatedAt = DateTime.Now.AddDays(-4), Tags = new[] { "Labour", "HR" } },
    };
}
