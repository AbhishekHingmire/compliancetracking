using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;

namespace RegWatch.Web.Controllers;

[Authorize]
public class RegulationController : Controller
{
    public IActionResult Library(string? search, string? body, string? priority, int page = 1)
    {
        ViewData["Title"] = "Regulation Library";
        var regulations = GetSampleRegulations();

        if (!string.IsNullOrWhiteSpace(search))
            regulations = regulations.Where(r => r.Title.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
        if (!string.IsNullOrWhiteSpace(body))
            regulations = regulations.Where(r => r.RegulatoryBody == body).ToList();
        if (!string.IsNullOrWhiteSpace(priority))
            regulations = regulations.Where(r => r.Priority == priority).ToList();

        var vm = new RegulationLibraryViewModel
        {
            Regulations = regulations.Skip((page - 1) * 20).Take(20).ToList(),
            SearchQuery = search,
            FilterBody = body,
            FilterPriority = priority,
            Page = page,
            PageSize = 20,
            TotalCount = regulations.Count
        };
        return View(vm);
    }

    private static List<RegulationItemViewModel> GetSampleRegulations() => new()
    {
        new() { Id = 1, Title = "GST Rate Change on Synthetic Textile Products", RegulatoryBody = "CBIC", Priority = "High", PublishedAt = DateTime.Now.AddDays(-2), EffectiveDate = DateTime.Today.AddMonths(1), SummaryEn = "Revised GST rates on synthetic textile products under HS 5402.", Tags = new[] { "GST", "Textile" }, IsNew = true },
        new() { Id = 2, Title = "SEBI Listing Obligations — Board Composition Norms", RegulatoryBody = "SEBI", Priority = "Medium", PublishedAt = DateTime.Now.AddDays(-5), EffectiveDate = DateTime.Today.AddDays(60), SummaryEn = "Amendment to SEBI (LODR) Regulations regarding independent directors.", Tags = new[] { "SEBI", "Corporate Governance" } },
        new() { Id = 3, Title = "EPF Wage Ceiling Enhancement", RegulatoryBody = "EPFO", Priority = "High", PublishedAt = DateTime.Now.AddDays(-10), EffectiveDate = DateTime.Today.AddDays(30), SummaryEn = "EPFO raises wage ceiling from ₹15,000 to ₹21,000 for mandatory PF.", Tags = new[] { "PF", "Payroll" } },
        new() { Id = 4, Title = "Income Tax — Budget 2024 Key Changes", RegulatoryBody = "IT Dept", Priority = "High", PublishedAt = DateTime.Now.AddDays(-15), SummaryEn = "Budget 2024 changes: revised slabs, TDS rate rationalisation, new TCS rules.", Tags = new[] { "Income Tax", "Budget" } },
        new() { Id = 5, Title = "FSSAI Schedule 4 Amendment", RegulatoryBody = "FSSAI", Priority = "Medium", PublishedAt = DateTime.Now.AddDays(-20), SummaryEn = "Changes to food safety standards for packaged commodity labelling.", Tags = new[] { "Food Safety", "FSSAI" } },
        new() { Id = 6, Title = "Companies Act — Directors KYC Annual Filing", RegulatoryBody = "MCA", Priority = "Low", PublishedAt = DateTime.Now.AddDays(-7), EffectiveDate = DateTime.Today.AddDays(45), SummaryEn = "MCA mandates annual KYC for all directors via DIR-3 KYC by September.", Tags = new[] { "MCA", "Director KYC" } },
    };
}
