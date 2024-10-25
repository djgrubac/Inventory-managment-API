using System;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
	public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Products
            modelBuilder.Entity<Products>().HasData(
                new Products { Id = 1, Name = "Product 1", Price = 10.99M },
                new Products { Id = 2, Name = "Product 2", Price = 20.99M },
                new Products { Id = 3, Name = "Product 3", Price = 30.99M },
                new Products { Id = 4, Name = "Product 4", Price = 40.99M },
                new Products { Id = 5, Name = "Product 5", Price = 50.99M }
            );

            // Seed Users with random names
            modelBuilder.Entity<Users>().HasData(
                new Users { Id = 1, Username = "AdminUser", Role = "Admin", Password = "adminpassword" },
                new Users { Id = 2, Username = "JaneSmith", Role = "Customer", Password = "password1" },
                new Users { Id = 3, Username = "JohnDoe", Role = "Customer", Password = "password2" }
            );
        }
    }
}

