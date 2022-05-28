namespace ExampleWebApplication.ShopUI.Models;

public class ProductListViewModel
{
    public PagedData<Product> PagedProducts { get; set; }
    public string CurrentCategory { get; set; }
}
