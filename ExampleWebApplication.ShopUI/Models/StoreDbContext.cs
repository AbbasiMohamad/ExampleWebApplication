using Microsoft.EntityFrameworkCore;

namespace ExampleWebApplication.ShopUI.Models;

public class StoreDbContext : DbContext
{
    //ایجاد جدول و امکان دسترسی به آن جدول
    public DbSet<Product> Products { get; set; }
    public StoreDbContext(DbContextOptions options) : base(options)
    {
    }
}
