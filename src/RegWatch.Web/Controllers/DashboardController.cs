using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

[AllowAnonymous]
public class DashboardController : Controller
{
    public IActionResult Index() => View();
}
