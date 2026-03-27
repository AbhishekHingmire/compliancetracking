using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

public class ProfileController : Controller
{
    [HttpGet] public IActionResult Setup() => View();

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Setup(int step)
    {
        if (step >= 4) return RedirectToAction("Index", "Dashboard");
        return View();
    }
}
