namespace ExampleWebApplication.ShopUI.Models;

public interface IProductRepository
{
    List<Product> GetAll(int pageSize, int pageNumber);
}
