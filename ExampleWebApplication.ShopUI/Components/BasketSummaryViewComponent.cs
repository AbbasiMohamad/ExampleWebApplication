namespace ExampleWebApplication.ShopUI.Components;

public class BasketSummaryViewComponent : ViewComponent
{
    private readonly Basket _basketService;

    public BasketSummaryViewComponent(Basket basketService)
    {
        _basketService = basketService;
    }

    public IViewComponentResult Invoke() =>  View(_basketService);
    
}
