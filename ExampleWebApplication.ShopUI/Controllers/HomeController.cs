using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApplication.ShopUI.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
