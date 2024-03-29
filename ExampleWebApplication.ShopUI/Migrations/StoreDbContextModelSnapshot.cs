﻿// <auto-generated />
using System;
using ExampleWebApplication.ShopUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExampleWebApplication.ShopUI.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExampleWebApplication.ShopUI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mobile"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            Name = "PC"
                        });
                });

            modelBuilder.Entity("ExampleWebApplication.ShopUI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ExampleWebApplication.ShopUI.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("ExampleWebApplication.ShopUI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "This is an auto-renewed stored value card subscription. A stored value card is what Amazon uses to transmit your monthly service payment to Cricket Wireless. Each month, Amazon automatically charges your preferred payment method to a stored value card, which is then used by Cricket to pay for your wireless service plan.",
                            Name = "Apple iPhone 13 Pro ",
                            Price = 1100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "The large 3000 mAh battery with Smart Manager optimization can easily handle your daily demands with more than 14 hours of mixed usage in a single charge. A powerful Octa-core processor provides a smooth multitasking experience.",
                            Name = "Tracfone Alcatel TCL A3",
                            Price = 900
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "SAMSUNG Galaxy S22 Ultra Smartphone, Factory Unlocked Android Cell Phone, 128GB, 8K Camera & Video, Brightest Display, S Pen, Long Battery Life, Fast 4nm Processor, US Version, Phantom Black",
                            Name = "SAMSUNG Galaxy S22",
                            Price = 1000
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Motorola One 5G Ace | 2021 | 2-Day battery | Unlocked | Made for US by Motorola | 6/128GB | 48MP Camera | Hazy Silver",
                            Name = "Motorola One 5G Ace",
                            Price = 700
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "SGIN Laptop 12GB DDR4 512GB SSD, 14.1 Inch Windows 11 Celeron N4500, Full HD 1920x1080 Ultrabook Laptop Computer with 2xUSB 3.0, Up to 2.8Ghz, 2.4/5.0G WiFi, Supports 512GB TF Card Expansion",
                            Name = "SGIN Laptop",
                            Price = 390
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "SGIN Laptop 12GB DDR4 512GB SSD, 15.6 Inch Windows 11 Laptops with Intel Celeron N4500 Processor, FHD 1920x1080 Display, 2xUSB 3.0, 2.4/5.0G WiFi, Bluetooth 4.2, Supports 512GB TF Card Expansion",
                            Name = "SGIN Laptop 12GB",
                            Price = 410
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Acer Aspire 5 A515-46-R3UB | 15.6\" Full HD IPS Display | AMD Ryzen 3 3350U Quad - Core Mobile Processor | 4GB DDR4 | 128GB NVMe SSD | WiFi 6 | Backlit KB | FPR | Amazon Alexa | Windows 11 Home in S mode",
                            Name = "Acer Aspire 5 ",
                            Price = 370
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Acer Nitro 5 AN515-57-79TD Gaming Laptop | Intel Core i7-11800H | NVIDIA GeForce RTX 3050 Ti Laptop GPU | 15.6\" FHD 144Hz IPS Display | 8GB DDR4 | 512GB NVMe SSD | Killer Wi - Fi 6 | Backlit Keyboard",
                            Name = "Acer Nitro 5",
                            Price = 1000
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "Lenovo ThinkPad P15v Gen 2 15.6\" FHD IPS Business Laptop(Intel i7 - 11800H 8 - Core, 32GB RAM, 1TB PCIe SSD, T600, 60Hz(1920x1080), Fingerprint, WiFi, Win 10 Pro) with Hub",
                            Name = "Lenovo ThinkPad P15v ",
                            Price = 1700
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Intel i5 12-Thread Gamer PC (Intel i5-10400F 4.3GHz, 16GB DDR4 3000, GT 1030 2GB GDDR5, 512 GB SSD, 802.11AC WiFi & Win 10 Prof) Black #5826",
                            Name = "Intel i5 12-Thread Gamer PC",
                            Price = 500
                        });
                });

            modelBuilder.Entity("ExampleWebApplication.ShopUI.Models.OrderDetail", b =>
                {
                    b.HasOne("ExampleWebApplication.ShopUI.Models.Order", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");

                    b.HasOne("ExampleWebApplication.ShopUI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ExampleWebApplication.ShopUI.Models.Product", b =>
                {
                    b.HasOne("ExampleWebApplication.ShopUI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ExampleWebApplication.ShopUI.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
