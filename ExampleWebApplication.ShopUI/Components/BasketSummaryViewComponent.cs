namespace ExampleWebApplication.ShopUI.Components;

public class BasketSummaryViewComponent : ViewComponent
{
    private readonly Basket _basketService;

    public BasketSummaryViewComponent(Basket basketService)
    {
        _basketService = basketService;
    }

    public IViewComponentResult Invoke()
    {
        
        return View(_basketService);
    }
}
