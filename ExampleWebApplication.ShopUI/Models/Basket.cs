namespace ExampleWebApplication.ShopUI.Models;

public class Basket
{
    private List<BasketItem> _items = new();

    public void AddItem(Product product, int count)
    {
        var basketItem = _items.Where(x => x.Product.Id == product.Id).FirstOrDefault();
        
        if (basketItem != null)
        {
            basketItem.Quantity += count;
        }
        else
        {
            _items.Add(new BasketItem
            {
                Product = product,
                Quantity = count,
            });
        }
    }

    public void RemoveItem(Product product) => _items.RemoveAll(x => x.Product.Id == product.Id);

    public int TotalPrice() => _items.Sum(x => x.Product.Price * x.Quantity);

    public void Clear() => _items.Clear();

    public IEnumerable<BasketItem> Items => _items;

}

public class BasketItem
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}
