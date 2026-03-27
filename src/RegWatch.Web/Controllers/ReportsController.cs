using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;

namespace RegWatch.Web.Controllers;

[Authorize]
public class ReportsController : Controller
{
    public IActionResult Monthly()
    {
        ViewData["Title"] = "Monthly Compliance Report";
        var vm = new MonthlyReportViewModel
        {
            Month = "March",
            Year = DateTime.Today.Year,
            TotalAlerts = 24,
            HighPriority = 7,
            Actioned = 18,
            Pending = 6,
            TotalSavings = 312000,
            BodyBreakdown = new List<BodyBreakdownViewModel>
            {
                new() { Body = "CBIC / GST", AlertCount = 10, ActionedCount = 9 },
                new() { Body = "EPFO", AlertCount = 4, ActionedCount = 3 },
                new() { Body = "SEBI", AlertCount = 3, ActionedCount = 2 },
                new() { Body = "IT Department", AlertCount = 4, ActionedCount = 3 },
                new() { Body = "MCA", AlertCount = 3, ActionedCount = 1 },
            },
            PendingActions = new List<string>
            {
                "Update GST rate in ERP for synthetic textile items",
                "Revise employment contracts per new wage code",
                "File DIR-3 KYC for 2 directors before deadline",
                "Enable e-invoicing for subsidiary entities",
                "Update TDS rates post-budget amendment",
                "Renew FSSAI license for Pune unit",
            }
        };
        return View(vm);
    }
}
