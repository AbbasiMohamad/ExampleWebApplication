using ExampleWebApplication.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApplication.ShopUI.Controllers;
public class HomeController : Controller
{
    private readonly IProductRepository _productRepository;

    public HomeController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IActionResult Index()
    {
        return View(_productRepository.GetAll());
    }
}
