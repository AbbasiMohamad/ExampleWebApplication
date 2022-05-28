using ExampleWebApplication.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApplication.ShopUI.Controllers;
public class HomeController : Controller
{
    private readonly IProductRepository _productRepository;
    private int pageSize = 2;

    public HomeController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IActionResult Index(string category = "", int pageNumber = 1)
    {
        var viewModel = new ProductListViewModel
        {
            PagedProducts = _productRepository.GetAll(category, pageSize, pageNumber),
            CurrentCategory = category,
        };
        return View(viewModel);
    }
}
