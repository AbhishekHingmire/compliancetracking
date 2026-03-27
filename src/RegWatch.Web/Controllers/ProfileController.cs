using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;

namespace RegWatch.Web.Controllers;

[Authorize]
public class ProfileController : Controller
{
    [HttpGet]
    public IActionResult Setup()
    {
        ViewData["Title"] = "Set Up Your Profile";
        return View(new OnboardingViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Setup(OnboardingViewModel model)
    {
        if (!ModelState.IsValid) return View(model);
        // Demo: redirect to dashboard after setup
        return RedirectToAction("Index", "Dashboard");
    }
}
