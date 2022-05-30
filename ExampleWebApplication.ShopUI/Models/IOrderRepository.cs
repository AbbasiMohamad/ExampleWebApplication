namespace ExampleWebApplication.ShopUI.Models;

public interface IOrderRepository
{
    void Checkout(Order order);
}
