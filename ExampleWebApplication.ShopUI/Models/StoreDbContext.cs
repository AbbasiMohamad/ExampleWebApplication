using Microsoft.EntityFrameworkCore;

namespace ExampleWebApplication.ShopUI.Models;

public class StoreDbContext : DbContext
{

    public StoreDbContext(DbContextOptions options) : base(options)
    {
    }
}
