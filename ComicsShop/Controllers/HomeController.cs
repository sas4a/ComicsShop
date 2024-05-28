using Microsoft.AspNetCore.Mvc;

namespace ComicsShop.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}