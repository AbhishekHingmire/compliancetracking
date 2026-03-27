using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

[AllowAnonymous]
public class RegulationController : Controller
{
    public IActionResult Library() => View();
}
