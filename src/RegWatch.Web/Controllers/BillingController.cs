using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;

namespace RegWatch.Web.Controllers;

[Authorize]
public class BillingController : Controller
{
    public IActionResult Plans()
    {
        ViewData["Title"] = "Billing & Plans";
        var vm = new BillingViewModel
        {
            CurrentPlan = "Pro",
            MonthlyAmount = 2999,
            PaymentMethod = "card",
            CardLast4 = "4242",
            NextBillingDate = DateTime.Today.AddMonths(1),
            Invoices = new List<InvoiceViewModel>
            {
                new() { Id = 1, InvoiceNumber = "INV-2024-003", Date = DateTime.Today.AddMonths(-1), Amount = 2999, Status = "paid", InvoiceUrl = "#" },
                new() { Id = 2, InvoiceNumber = "INV-2024-002", Date = DateTime.Today.AddMonths(-2), Amount = 2999, Status = "paid", InvoiceUrl = "#" },
                new() { Id = 3, InvoiceNumber = "INV-2024-001", Date = DateTime.Today.AddMonths(-3), Amount = 999, Status = "paid", InvoiceUrl = "#" },
            }
        };
        return View(vm);
    }
}
