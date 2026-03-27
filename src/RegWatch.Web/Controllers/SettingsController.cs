using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;

namespace RegWatch.Web.Controllers;

[Authorize]
public class SettingsController : Controller
{
    [HttpGet]
    public IActionResult Notifications()
    {
        ViewData["Title"] = "Notification Settings";
        return View(new NotificationSettingsViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Notifications(NotificationSettingsViewModel model)
    {
        if (!ModelState.IsValid) return View(model);
        TempData["Success"] = "Settings saved successfully.";
        return RedirectToAction(nameof(Notifications));
    }
}
