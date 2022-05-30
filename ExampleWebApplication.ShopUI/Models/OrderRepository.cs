namespace ExampleWebApplication.ShopUI.Models;

public class OrderRepository : IOrderRepository
{
    private readonly StoreDbContext _context;

    public OrderRepository(StoreDbContext context)
    {
        _context = context;
    }
    public void Checkout(Order order)
    {
        _context.AttachRange(order.OrderDetails.Select(p => p.Product));
        _context.Orders.Add(order);
        _context.SaveChanges();
    }
}
