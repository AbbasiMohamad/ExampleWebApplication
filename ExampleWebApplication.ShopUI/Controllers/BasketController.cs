namespace ExampleWebApplication.ShopUI.Controllers;
public class BasketController : Controller
{
    private readonly IProductRepository _productRepository;
    private readonly Basket _sessionBasket;

    public BasketController(IProductRepository productRepository, Basket sessionBasket)
    {
        _productRepository = productRepository;
        _sessionBasket = sessionBasket;
    }


    public IActionResult Index(string returnUrl)
    {
        var basketPageViewModel = new BasketPageViewModel
        {
            Basket = _sessionBasket,
            ReturnUrl = returnUrl
        };

        return View(basketPageViewModel);
    }


    [HttpPost]
    public IActionResult AddToBasket(int productId, string returnUrl)
    {
        var product = _productRepository.GetById(productId);
        _sessionBasket.AddItem(product, 1);
        return RedirectToAction("Index", new { returnUrl = returnUrl });
    }

    [HttpPost]
    public IActionResult RemoveFromBasket(int productId, string returnUrl)
    {
        var product = _productRepository.GetById(productId);
        _sessionBasket.RemoveItem(product);
        return RedirectToAction("Index", new { returnUrl = returnUrl });
    }

}
