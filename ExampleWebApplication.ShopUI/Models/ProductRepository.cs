namespace ExampleWebApplication.ShopUI.Models;

public class ProductRepository : IProductRepository
{
    private readonly StoreDbContext _context;

    public ProductRepository(StoreDbContext context)
    {
        _context = context;
    }
    public PagedData<Product> GetAll(string category, int pageSize, int pageNumber)
    {
        var pagedResult = new PagedData<Product>()
        {
            PageInfo = new PageInfo
            {
                PageSize = pageSize,
                PageNumber = pageNumber,
                TotalCount = _context.Products
                    .Where(c => string.IsNullOrEmpty(category) || c.Category.Name == category).Count()
            }
        };
        pagedResult.Data = _context.Products
            .Where(c => string.IsNullOrEmpty(category) || c.Category.Name == category)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        
        return pagedResult;
    }

    

    public Product GetById(int productId) => _context.Products.FirstOrDefault(c => c.Id == productId);
}
