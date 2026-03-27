using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public IActionResult Dashboard()
    {
        ViewData["Title"] = "Admin Dashboard";
        ViewBag.TotalTenants = 247;
        ViewBag.ActiveSubscriptions = 189;
        ViewBag.TotalAlerts = 15823;
        ViewBag.ScrapedToday = 432;
        ViewBag.MonthlyRevenue = 487503;
        return View();
    }
}
