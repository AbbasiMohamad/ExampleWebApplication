namespace ExampleWebApplication.ShopUI.Models;

public interface IProductRepository
{
    PagedData<Product> GetAll(int pageSize, int pageNumber);
}
