using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

[AllowAnonymous]
public class AlertsController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Detail(int id) => View();
}
