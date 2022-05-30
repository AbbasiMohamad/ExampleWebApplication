namespace ExampleWebApplication.ShopUI.Models;

public class Basket
{
    private List<BasketItem> _items = new();

    public virtual void AddItem(Product product, int count)
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

    public virtual void RemoveItem(Product product) => _items.RemoveAll(x => x.Product.Id == product.Id);

    public int TotalPrice() => _items.Sum(x => x.Product.Price * x.Quantity);

    public virtual void Clear() => _items.Clear();

    public IEnumerable<BasketItem> Items => _items;

}

public class BasketItem
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}


public class SessionBasket : Basket
{
    private const string sessionKey = "Basket";
    private ISession _session;

    public static SessionBasket GetBasket(IServiceProvider serviceProvider)
    {
        var session = serviceProvider.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
        SessionBasket basket = session.GetJson<SessionBasket>(sessionKey);
        basket._session = session;
        return basket;
    }

    public override void AddItem(Product product, int count)
    {
        base.AddItem(product, count);
        _session.SetJson(sessionKey, this);
    }

    public override void RemoveItem(Product product)
    {
        base.RemoveItem(product);
        _session.SetJson(sessionKey, this);
    }

    public override void Clear()
    {
        base.Clear();
        _session.Remove(sessionKey);
    }
}