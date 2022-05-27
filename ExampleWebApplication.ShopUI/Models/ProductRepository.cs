namespace ExampleWebApplication.ShopUI.Models;

public class ProductRepository : IProductRepository
{
    private readonly StoreDbContext _context;

    public ProductRepository(StoreDbContext context)
    {
        _context = context;
    }
    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }
}
