using Microsoft.AspNetCore.Mvc;

namespace AspNet10LTSWebsite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

