namespace ExampleWebApplication.ShopUI.Models;

public interface IProductRepository
{
    PagedData<Product> GetAll(string category, int pageSize, int pageNumber);

    List<string> GetAllCategories();
}
