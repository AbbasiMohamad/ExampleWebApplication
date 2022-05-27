using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleWebApplication.ShopUI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Categoty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Categoty", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Mobile", "This is an auto-renewed stored value card subscription. A stored value card is what Amazon uses to transmit your monthly service payment to Cricket Wireless. Each month, Amazon automatically charges your preferred payment method to a stored value card, which is then used by Cricket to pay for your wireless service plan.", "Apple iPhone 13 Pro ", 1100 },
                    { 2, "Mobile", "The large 3000 mAh battery with Smart Manager optimization can easily handle your daily demands with more than 14 hours of mixed usage in a single charge. A powerful Octa-core processor provides a smooth multitasking experience.", "Tracfone Alcatel TCL A3", 900 },
                    { 3, "Mobile", "SAMSUNG Galaxy S22 Ultra Smartphone, Factory Unlocked Android Cell Phone, 128GB, 8K Camera & Video, Brightest Display, S Pen, Long Battery Life, Fast 4nm Processor, US Version, Phantom Black", "SAMSUNG Galaxy S22", 1000 },
                    { 4, "Mobile", "Motorola One 5G Ace | 2021 | 2-Day battery | Unlocked | Made for US by Motorola | 6/128GB | 48MP Camera | Hazy Silver", "Motorola One 5G Ace", 700 },
                    { 5, "Laptop", "SGIN Laptop 12GB DDR4 512GB SSD, 14.1 Inch Windows 11 Celeron N4500, Full HD 1920x1080 Ultrabook Laptop Computer with 2xUSB 3.0, Up to 2.8Ghz, 2.4/5.0G WiFi, Supports 512GB TF Card Expansion", "SGIN Laptop", 390 },
                    { 6, "Laptop", "SGIN Laptop 12GB DDR4 512GB SSD, 15.6 Inch Windows 11 Laptops with Intel Celeron N4500 Processor, FHD 1920x1080 Display, 2xUSB 3.0, 2.4/5.0G WiFi, Bluetooth 4.2, Supports 512GB TF Card Expansion", "SGIN Laptop 12GB", 410 },
                    { 7, "Laptop", "Acer Aspire 5 A515-46-R3UB | 15.6\" Full HD IPS Display | AMD Ryzen 3 3350U Quad - Core Mobile Processor | 4GB DDR4 | 128GB NVMe SSD | WiFi 6 | Backlit KB | FPR | Amazon Alexa | Windows 11 Home in S mode", "Acer Aspire 5 ", 370 },
                    { 8, "Laptop", "Acer Nitro 5 AN515-57-79TD Gaming Laptop | Intel Core i7-11800H | NVIDIA GeForce RTX 3050 Ti Laptop GPU | 15.6\" FHD 144Hz IPS Display | 8GB DDR4 | 512GB NVMe SSD | Killer Wi - Fi 6 | Backlit Keyboard", "Acer Nitro 5", 1000 },
                    { 9, "Laptop", "Lenovo ThinkPad P15v Gen 2 15.6\" FHD IPS Business Laptop(Intel i7 - 11800H 8 - Core, 32GB RAM, 1TB PCIe SSD, T600, 60Hz(1920x1080), Fingerprint, WiFi, Win 10 Pro) with Hub", "Lenovo ThinkPad P15v ", 1700 },
                    { 10, "PC", "Intel i5 12-Thread Gamer PC (Intel i5-10400F 4.3GHz, 16GB DDR4 3000, GT 1030 2GB GDDR5, 512 GB SSD, 802.11AC WiFi & Win 10 Prof) Black #5826", "Intel i5 12-Thread Gamer PC", 500 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
