﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ROCVESTAPI.Data;

namespace ROCVESTAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ROCVESTAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Category 1",
                            Image = "image1.jpg",
                            Price = 10.99m,
                            Quantity = 100,
                            ShortDesc = "Short description for Product 1",
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Category 2",
                            Image = "image2.jpg",
                            Price = 20.99m,
                            Quantity = 150,
                            ShortDesc = "Short description for Product 2",
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Category 3",
                            Image = "image3.jpg",
                            Price = 30.99m,
                            Quantity = 350,
                            ShortDesc = "Short description for Product 3",
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Category 4",
                            Image = "image4.jpg",
                            Price = 40.70m,
                            Quantity = 480,
                            ShortDesc = "Short description for Product 4",
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Category 5",
                            Image = "image5.jpg",
                            Price = 20.99m,
                            Quantity = 550,
                            ShortDesc = "Short description for Product 5",
                            Title = "Product 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
