using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegWatch.Web.Models.ViewModels;
using System.Security.Claims;

namespace RegWatch.Web.Controllers;

[AllowAnonymous]
public class AuthController : Controller
{
    [HttpGet]
    public IActionResult Login(string? returnUrl = null)
    {
        ViewData["Title"] = "Sign In";
        ViewData["ReturnUrl"] = returnUrl;
        return View(new LoginViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
    {
        ViewData["Title"] = "Sign In";
        if (!ModelState.IsValid) return View(model);

        // Demo: accept any credentials — replace with real auth
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, model.Email),
            new(ClaimTypes.Email, model.Email),
            new(ClaimTypes.Role, "owner"),
        };
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);
        var props = new AuthenticationProperties { IsPersistent = model.RememberMe };
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);

        return LocalRedirect(returnUrl ?? "/dashboard");
    }

    [HttpGet]
    public IActionResult Register()
    {
        ViewData["Title"] = "Create Account";
        return View(new RegisterViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        ViewData["Title"] = "Create Account";
        if (!ModelState.IsValid) return View(model);

        // Demo: auto-sign in after registration — replace with real logic
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, model.Name),
            new(ClaimTypes.Email, model.Email),
            new(ClaimTypes.Role, "owner"),
        };
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

        return RedirectToAction("Setup", "Profile");
    }

    [HttpPost]
    [Authorize]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home");
    }
}
