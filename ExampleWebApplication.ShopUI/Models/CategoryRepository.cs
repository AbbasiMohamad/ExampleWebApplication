namespace ExampleWebApplication.ShopUI.Models;

public class CategoryRepository : ICategoryRepository
{
    private readonly StoreDbContext _context;

    public CategoryRepository(StoreDbContext context)
    {
        _context = context;
    }
    public List<string> GetAllCategories() =>
        _context.Categories.Select(c => c.Name).ToList();
}
