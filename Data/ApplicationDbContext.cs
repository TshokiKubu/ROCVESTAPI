using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ROCVESTAPI.Models;

namespace ROCVESTAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data for the Product table
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Product 1",
                    Image = "image1.jpg",
                    Price = 10.99m,
                    ShortDesc = "Short description for Product 1",
                    Quantity = 100,
                    Category = "Category 1"
                },
                new Product
                {
                    Id = 2,
                    Title = "Product 2",
                    Image = "image2.jpg",
                    Price = 20.99m,
                    ShortDesc = "Short description for Product 2",
                    Quantity = 150,
                    Category = "Category 2"
                }
                ,
                new Product
                {
                    Id = 3,
                    Title = "Product 3",
                    Image = "image3.jpg",
                    Price = 30.99m,
                    ShortDesc = "Short description for Product 3",
                    Quantity = 350,
                    Category = "Category 3"
                },
                new Product
                {
                    Id = 4,
                    Title = "Product 4",
                    Image = "image4.jpg",
                    Price = 40.70m,
                    ShortDesc = "Short description for Product 4",
                    Quantity = 480,
                    Category = "Category 4"
                },
                new Product
                {
                    Id = 5,
                    Title = "Product 5",
                    Image = "image5.jpg",
                    Price = 20.99m,
                    ShortDesc = "Short description for Product 5",
                    Quantity = 550,
                    Category = "Category 5"
                }
            );
        }
    }
}