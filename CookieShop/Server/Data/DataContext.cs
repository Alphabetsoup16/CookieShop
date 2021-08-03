using System;
using System.Collections.Generic;
using CookieShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace CookieShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Edition> Editions { get; set; }

        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });



            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cookies", Url = "cookies", Icon = "palette" },
                new Category { Id = 2, Name = "Cakes", Url = "cakes", Icon = "egg" },
                new Category { Id = 3, Name = "Specialty", Url = "specialty", Icon = "shop" }
           
            );
            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Chocolate Chip",
                    Description = "Classic chocolate chip cookie with a pinch of sea salt",
                    Image = "https://images.unsplash.com/photo-1499636136210-6f4ee915583e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=800&q=80",
                    DateCreated = new DateTime(2021, 7, 25)
              },
              new Product
              {
                  Id = 2,
                  CategoryId = 3,
                  Title = "Brownie",
                  Description = "Double chocolate fudge brownies",
                  Image = "https://images.unsplash.com/photo-1605190557072-1fe6a230ee65?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=670&q=80",
                  DateCreated = new DateTime(2021, 7, 25)
              },
              new Product
              {
                  Id = 3,
                  CategoryId = 3,
                  Title = "Ice Cream Sandwiches",
                  Description = "Delicious ice cream between two chocolate chip cookies",
                  Image = "https://images.unsplash.com/photo-1559622214-f8a9850965bb?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=802&q=80",
                  DateCreated = new DateTime(2021, 7, 25)
              },
              new Product
              {
                  Id = 4,
                  CategoryId = 1,
                  Title = "Chocolate Stuffed Cookie",
                  Description = "Rich chocolate cookie stuffed with white and dark chocolate",
                  Image = "https://images.unsplash.com/photo-1619149651177-b09092806f1a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=668&q=80",
                  DateCreated = new DateTime(2021, 7, 25)
              },
              new Product
              {
                  Id = 5,
                  CategoryId = 1,
                  Title = "Sprinkle Cookie",
                  Description = "Our second most popular!",
                  Image = "https://images.unsplash.com/photo-1558455806-316856e5b499?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=802&q=80",
                  DateCreated = new DateTime(2021, 7, 25)
              },
              new Product
              {
                  Id = 6,
                  CategoryId = 3,
                  Title = "Cookie Dough",
                  Description = "A full tub of our famous double chocolate cookie dough",
                  Image = "https://images.unsplash.com/photo-1511382091779-4dedcc34e19b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8Y29va2llJTIwZG91Z2h8ZW58MHx8MHx8&auto=format&fit=crop&w=900&q=60",
                  DateCreated = new DateTime(2021, 7, 25)
              },
              new Product
              {
                  Id = 7,
                  CategoryId = 2,
                  Title = "Waffle Crumb Cake",
                  Description = "Belgian waffle cookie crumble on vanilla custard with a graham cracker base",
                  Image = "https://images.unsplash.com/photo-1567954357754-b144384c0dcc?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=826&q=80",
                  DateCreated = new DateTime(2021, 7, 25)
              },
              new Product
              {
                  Id = 8,
                  CategoryId = 2,
                  Title = "Chocolate Mousse Cake",
                  Description = "Double chocolate cookie base with rich chocolate gnache and mousse layers",
                  Image = "https://images.unsplash.com/photo-1602351447937-745cb720612f?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=666&q=80",
                  DateCreated = new DateTime(2021, 7, 25)
              },
              new Product
              {
                  Id = 9,
                  CategoryId = 2,
                  Title = "Banana Bread",
                  Description = "A full loaf of our famous banana bread",
                  Image = "https://images.unsplash.com/photo-1605286978633-2dec93ff88a2?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1055&q=80",
                  DateCreated = new DateTime(2021, 7, 25)
              }
            );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default"},
                new Edition { Id = 2, Name = "Gluten free" },
                new Edition { Id = 3, Name = "Organic" },
                new Edition { Id = 4, Name = "Sugar free" },
                new Edition { Id = 5, Name = "Nut free" },
                new Edition { Id = 6, Name = "Regular icecream" },
                new Edition { Id = 7, Name = "Dairy free icecream" },
                new Edition { Id = 8, Name = "Frosted" },
                new Edition { Id = 9, Name = "Unfrosted" }
                
                );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 1,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 5,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 2,
                    Price = 3.99m,
                    OriginalPrice = 5.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 3,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 4,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 5,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 2,
                    Price = 3.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 3,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 4,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 5,
                    Price = 4.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 1,
                    Price = 5.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 6,
                    Price = 6.99m,
                    OriginalPrice = 8.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 7,
                    Price = 6.99m,
                    OriginalPrice = 8.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 9,
                    Price = 29.99m,
                    OriginalPrice = 39.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 8,
                    Price = 39.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 9,
                    Price = 39.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 8,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 9,
                    Price = 14.99m,
                    OriginalPrice = 16.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 8,
                    Price = 24.99m,
                    OriginalPrice = 34.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 1,
                    Price = 4.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 4.99m,
                    OriginalPrice = 5.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 4,
                    Price = 5.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 5.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 2,
                    Price = 5.99m,
                    OriginalPrice = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 3,
                    Price = 9.99m,
                    
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 5,
                    Price = 15.99m,
                    
                }
                );
            
        }

    }
}
