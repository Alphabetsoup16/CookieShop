﻿// <auto-generated />
using System;
using CookieShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CookieShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210725151216_ProductEditions")]
    partial class ProductEditions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CookieShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "palette",
                            Name = "Cookies",
                            Url = "cookies"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "egg",
                            Name = "Cakes",
                            Url = "cakes"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "shop",
                            Name = "Specialty",
                            Url = "specialty"
                        });
                });

            modelBuilder.Entity("CookieShop.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");
                });

            modelBuilder.Entity("CookieShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Classic chocolate chip cookie with a pinch of sea salt",
                            Image = "https://images.unsplash.com/photo-1499636136210-6f4ee915583e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=800&q=80",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 15.99m,
                            Price = 9.99m,
                            Title = "Chocolate Chip"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Double chocolate fudge brownies",
                            Image = "https://images.unsplash.com/photo-1605190557072-1fe6a230ee65?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=670&q=80",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Brownie"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Delicious ice cream between two chocolate chip cookies",
                            Image = "https://images.unsplash.com/photo-1559622214-f8a9850965bb?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=802&q=80",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Ice Cream Sandwiches"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rich chocolate cookie stuffed with white and dark chocolate",
                            Image = "https://images.unsplash.com/photo-1619149651177-b09092806f1a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=668&q=80",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Chocolate Stuffed Cookie"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Our second most popular!",
                            Image = "https://images.unsplash.com/photo-1558455806-316856e5b499?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=802&q=80",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Sprinkle Cookie"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A full tub of our famous double chocolate cookie dough",
                            Image = "https://images.unsplash.com/photo-1511382091779-4dedcc34e19b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8Y29va2llJTIwZG91Z2h8ZW58MHx8MHx8&auto=format&fit=crop&w=900&q=60",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 19.99m,
                            Title = "Cookie Dough"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Belgian waffle cookie crumble on vanilla custard with a graham cracker base",
                            Image = "https://images.unsplash.com/photo-1567954357754-b144384c0dcc?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=826&q=80",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 59.99m,
                            Price = 29.99m,
                            Title = "Waffle Crumb Cake"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Double chocolate cookie base with rich chocolate gnache and mousse layers",
                            Image = "https://images.unsplash.com/photo-1602351447937-745cb720612f?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=666&q=80",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 69.99m,
                            Price = 39.99m,
                            Title = "Chocolate Mousse Cake"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A full loaf of our famous banana bread",
                            Image = "https://images.unsplash.com/photo-1605286978633-2dec93ff88a2?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1055&q=80",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 19.99m,
                            Title = "Banana Bread"
                        });
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.Property<int>("EditionsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("EditionsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("EditionProduct");
                });

            modelBuilder.Entity("CookieShop.Shared.Product", b =>
                {
                    b.HasOne("CookieShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.HasOne("CookieShop.Shared.Edition", null)
                        .WithMany()
                        .HasForeignKey("EditionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookieShop.Shared.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
