using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

public class AdminController : Controller
{
    public IActionResult Dashboard() => View();
}
