using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;

namespace RegWatch.Web.Controllers;

[AllowAnonymous]
public class AuthController : Controller
{
    [HttpGet] public IActionResult Login() => View(new LoginViewModel());

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Login(LoginViewModel model)
    {
        if (!ModelState.IsValid) return View(model);
        return RedirectToAction("Index", "Dashboard");
    }

    [HttpGet] public IActionResult Register() => View(new RegisterViewModel());

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid) return View(model);
        return RedirectToAction("Setup", "Profile");
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Logout() => RedirectToAction("Index", "Home");
}
