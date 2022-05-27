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
        var pagedData = new PagedData<Product>();
        var totalCount = _context.Products.Count();
        pagedData.Data = _context.Products
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        pagedData.PageInfo = new PageInfo
        {
            PageSize = pageSize,
            PageNumber = pageNumber,
            TotalCount = totalCount
        };
        return pagedData;
    }
}
