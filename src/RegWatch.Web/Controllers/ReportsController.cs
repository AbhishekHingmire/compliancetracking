using Microsoft.AspNetCore.Mvc;

namespace RegWatch.Web.Controllers;

public class ReportsController : Controller
{
    public IActionResult Monthly() => View();
}
