namespace ExampleWebApplication.ShopUI.Models;

public class ProductRepository : IProductRepository
{
    private readonly StoreDbContext _context;

    public ProductRepository(StoreDbContext context)
    {
        _context = context;
    }
    public PagedData<Product> GetAll(int pageSize, int pageNumber)
    {
        var pagedResult = new PagedData<Product>()
        {
            PageInfo = new PageInfo
            {
                PageSize = pageSize,
                PageNumber = pageNumber,
                TotalCount = _context.Products.Count()
            }
        };
        pagedResult.Data = _context.Products
            .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        
        return pagedResult;
    }
}
