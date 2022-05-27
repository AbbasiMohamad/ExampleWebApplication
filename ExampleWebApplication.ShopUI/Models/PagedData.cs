namespace ExampleWebApplication.ShopUI.Models;

public class PagedData<T>
{
    public List<T> Data { get; set; }
    public PageInfo PageInfo { get; set; }
}
