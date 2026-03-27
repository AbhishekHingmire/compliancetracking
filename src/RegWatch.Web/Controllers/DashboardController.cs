using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;

namespace RegWatch.Web.Controllers;

[Authorize]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Dashboard";
        var vm = new DashboardViewModel
        {
            UrgentCount = 3,
            ThisMonthCount = 12,
            CompletedCount = 28,
            TotalCount = 45,
            EstimatedSavings = 240000,
            WeeklyActivity = new List<int> { 2, 5, 3, 8, 4, 6, 3 },
            RecentAlerts = new List<AlertItemViewModel>
            {
                new() { Id = 1, Title = "GST Rate Change on Textile Products", Body = "CBIC notified revised GST rates on synthetic textile products effective 1 April.", Priority = "High", Status = "unread", RegulatoryBody = "CBIC", CreatedAt = DateTime.Now.AddHours(-2), EstimatedSaving = 85000, Tags = new[] { "GST", "Textile" } },
                new() { Id = 2, Title = "PF Contribution Threshold Revised", Body = "EPFO revised salary threshold for mandatory PF contribution to ₹21,000/month.", Priority = "High", Status = "unread", RegulatoryBody = "EPFO", CreatedAt = DateTime.Now.AddHours(-5), EstimatedSaving = 36000, Tags = new[] { "PF", "HR" } },
                new() { Id = 3, Title = "SEBI LODR Amendment — Board Composition", Body = "Listed entities must ensure at least one independent woman director by 31 March.", Priority = "Medium", Status = "read", RegulatoryBody = "SEBI", CreatedAt = DateTime.Now.AddDays(-1), Tags = new[] { "SEBI", "Corporate" } },
            },
            UpcomingDeadlines = new List<DeadlineItemViewModel>
            {
                new() { Id = 1, Title = "GST Monthly Return (GSTR-3B)", DueDate = DateTime.Today.AddDays(5), Status = "pending", IsRecurring = true },
                new() { Id = 2, Title = "TDS Payment Q4", DueDate = DateTime.Today.AddDays(12), Status = "pending" },
                new() { Id = 3, Title = "Annual Report Filing (MCA)", DueDate = DateTime.Today.AddDays(21), Status = "pending" },
                new() { Id = 4, Title = "ESI Contribution", DueDate = DateTime.Today.AddDays(3), Status = "pending", IsRecurring = true },
            }
        };
        return View(vm);
    }
}
