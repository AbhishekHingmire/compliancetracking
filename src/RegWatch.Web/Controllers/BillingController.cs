using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

public class BillingController : Controller
{
    public IActionResult Plans() => View();

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Upgrade(string plan) => RedirectToAction(nameof(Plans));
}
