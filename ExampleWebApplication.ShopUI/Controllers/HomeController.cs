using ExampleWebApplication.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApplication.ShopUI.Controllers;
public class HomeController : Controller
{
    private readonly IProductRepository _productRepository;
    private int pageSize = 4;

    public HomeController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IActionResult Index(int pageNumber=1)
    {
        return View(_productRepository.GetAll(pageSize, pageNumber));
    }
}
