using Microsoft.EntityFrameworkCore;

namespace ExampleWebApplication.ShopUI.Models;

public class StoreDbContext : DbContext
{
    // Microsoft.EntityFrameworkCore.SqlServer (for ef classes)
    // Microsoft.EntityFrameworkCore.Tools (for do migration)


    //ایجاد جدول و امکان دسترسی به آن جدول
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Category> Categories { get; set; }

    public StoreDbContext(DbContextOptions options) : base(options)
    {
    }


    //تنظیمات مربوط به انتیتی ها در اینجا قرار میگیرد
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Mobile"
            },
            new Category
            {
                Id = 2,
                Name = "Laptop"
            },
            new Category
            {
                Id = 3,
                Name = "PC"
            });

        //اضافه کردن دیتای اولیه
        modelBuilder.Entity<Product>().HasData(

            new Product
            {
                Id = 1,
                Name = "Apple iPhone 13 Pro ",
                Description = "This is an auto-renewed stored value card subscription. A stored value card is what Amazon uses to transmit your monthly service payment to Cricket Wireless. Each month, Amazon automatically charges your preferred payment method to a stored value card, which is then used by Cricket to pay for your wireless service plan.",
                Price = 1100,
                CategoryId = 1,
            },
            new Product
            {
                Id = 2,
                Name = "Tracfone Alcatel TCL A3",
                Description = "The large 3000 mAh battery with Smart Manager optimization can easily handle your daily demands with more than 14 hours of mixed usage in a single charge. A powerful Octa-core processor provides a smooth multitasking experience.",
                Price = 900,
                CategoryId = 1,
            },
            new Product
            {
                Id = 3,
                Name = "SAMSUNG Galaxy S22",
                Description = "SAMSUNG Galaxy S22 Ultra Smartphone, Factory Unlocked Android Cell Phone, 128GB, 8K Camera & Video, Brightest Display, S Pen, Long Battery Life, Fast 4nm Processor, US Version, Phantom Black",
                Price = 1000,
                CategoryId = 1,
            },
            new Product
            {
                Id = 4,
                Name = "Motorola One 5G Ace",
                Description = "Motorola One 5G Ace | 2021 | 2-Day battery | Unlocked | Made for US by Motorola | 6/128GB | 48MP Camera | Hazy Silver",
                Price = 700,
                CategoryId = 1,
            },
            new Product
            {
                Id = 5,
                Name = "SGIN Laptop",
                Description = "SGIN Laptop 12GB DDR4 512GB SSD, 14.1 Inch Windows 11 Celeron N4500, Full HD 1920x1080 Ultrabook Laptop Computer with 2xUSB 3.0, Up to 2.8Ghz, 2.4/5.0G WiFi, Supports 512GB TF Card Expansion",
                Price = 390,
                CategoryId = 2,
            },
            new Product
            {
                Id = 6,
                Name = "SGIN Laptop 12GB",
                Description = "SGIN Laptop 12GB DDR4 512GB SSD, 15.6 Inch Windows 11 Laptops with Intel Celeron N4500 Processor, FHD 1920x1080 Display, 2xUSB 3.0, 2.4/5.0G WiFi, Bluetooth 4.2, Supports 512GB TF Card Expansion",
                Price = 410,
                CategoryId = 2,
            },
            new Product
            {
                Id = 7,
                Name = "Acer Aspire 5 ",
                Description = "Acer Aspire 5 A515-46-R3UB | 15.6\" Full HD IPS Display | AMD Ryzen 3 3350U Quad - Core Mobile Processor | 4GB DDR4 | 128GB NVMe SSD | WiFi 6 | Backlit KB | FPR | Amazon Alexa | Windows 11 Home in S mode",
                Price = 370,
                CategoryId = 2,
            },
            new Product
            {
                Id = 8,
                Name = "Acer Nitro 5",
                Description = "Acer Nitro 5 AN515-57-79TD Gaming Laptop | Intel Core i7-11800H | NVIDIA GeForce RTX 3050 Ti Laptop GPU | 15.6\" FHD 144Hz IPS Display | 8GB DDR4 | 512GB NVMe SSD | Killer Wi - Fi 6 | Backlit Keyboard",
                Price = 1000,
                CategoryId = 2,
            },
            new Product
            {
                Id = 9,
                Name = "Lenovo ThinkPad P15v ",
                Description = "Lenovo ThinkPad P15v Gen 2 15.6\" FHD IPS Business Laptop(Intel i7 - 11800H 8 - Core, 32GB RAM, 1TB PCIe SSD, T600, 60Hz(1920x1080), Fingerprint, WiFi, Win 10 Pro) with Hub",
                Price = 1700,
                CategoryId = 2,
            },
            new Product
            {
                Id = 10,
                Name = "Intel i5 12-Thread Gamer PC",
                Description = "Intel i5 12-Thread Gamer PC (Intel i5-10400F 4.3GHz, 16GB DDR4 3000, GT 1030 2GB GDDR5, 512 GB SSD, 802.11AC WiFi & Win 10 Prof) Black #5826",
                Price = 500,
                CategoryId = 3,
            }

            );

        base.OnModelCreating(modelBuilder);
    }
}
