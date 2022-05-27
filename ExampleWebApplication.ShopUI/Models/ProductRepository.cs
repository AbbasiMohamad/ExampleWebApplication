namespace ExampleWebApplication.ShopUI.Models;

public class ProductRepository : IProductRepository
{
    private readonly StoreDbContext _context;

    public ProductRepository(StoreDbContext context)
    {
        _context = context;
    }
    public List<Product> GetAll(int pageSize, int pageNumber)
    {
        return _context.Products
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }
}
