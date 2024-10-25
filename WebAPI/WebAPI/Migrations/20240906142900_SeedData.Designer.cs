﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240906142900_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Product 1",
                            Price = 10.99m,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Product 2",
                            Price = 20.99m,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Product 3",
                            Price = 30.99m,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Product 4",
                            Price = 40.99m,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Product 5",
                            Price = 50.99m,
                            StockQuantity = 0
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "adminpassword",
                            Role = "Admin",
                            Username = "AdminUser"
                        },
                        new
                        {
                            Id = 2,
                            Password = "password1",
                            Role = "Customer",
                            Username = "JaneSmith"
                        },
                        new
                        {
                            Id = 3,
                            Password = "password2",
                            Role = "Customer",
                            Username = "JohnDoe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
