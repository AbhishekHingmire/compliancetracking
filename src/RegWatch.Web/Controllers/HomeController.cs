using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

[AllowAnonymous]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "RegWatch India — Never Miss a Regulation Change";
        return View();
    }

    public IActionResult Pricing()
    {
        ViewData["Title"] = "Pricing";
        return View();
    }

    public IActionResult About()
    {
        ViewData["Title"] = "About Us";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact Us";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new RegWatch.Web.Models.ViewModels.ErrorViewModel
        {
            RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}
