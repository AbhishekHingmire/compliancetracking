using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

public class SettingsController : Controller
{
    [HttpGet] public IActionResult Notifications() => View();

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Notifications(string submit)
    {
        TempData["Success"] = "Settings saved successfully.";
        return RedirectToAction(nameof(Notifications));
    }
}
