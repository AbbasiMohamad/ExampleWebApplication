using ExampleWebApplication.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExampleWebApplication.ShopUI.Controllers;
public class BasketController : Controller
{
    public IProductRepository _productRepository { get; }

    public BasketController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }


    public IActionResult Index(string returnUrl)
    {
        var basketPageViewModel = new BasketPageViewModel
        {
            Basket = GetBasket(),
            ReturnUrl = returnUrl
        };

        return View(basketPageViewModel);
    }


    [HttpPost]
    public IActionResult AddToBasket(int productId, string returnUrl)
    {
        var product = _productRepository.GetById(productId);
        var basket = GetBasket();
        basket.AddItem(product, 1);
        SaveBasket(basket);
        return RedirectToAction("Index", new { returnUrl = returnUrl });
    }

    [HttpPost]
    public IActionResult RemoveFromBasket(int productId, string returnUrl)
    {
        var product = _productRepository.GetById(productId);
        var basket = GetBasket();
        basket.RemoveItem(product);
        SaveBasket(basket);
        return RedirectToAction("Index", new { returnUrl = returnUrl });
    }


    private Basket GetBasket()
    {
        var basketString = HttpContext.Session.GetString("Basket");
        if (string.IsNullOrEmpty(basketString))
        {
            return new Basket();
        }
        return JsonConvert.DeserializeObject<Basket>(basketString);
    }

    private void SaveBasket(Basket basket)
    {
        HttpContext.Session.SetString("Basket", JsonConvert.SerializeObject(basket));
    }
}
