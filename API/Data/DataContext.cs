using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>
            {
                new Product { Id = 1, Name = "iPhone 15", Description = "Apple iPhone 15, 128GB, Black", ImageUrl = "iphone15.jpg", Price = 600, IsActive = true, Stock = 100 },
                new Product { Id = 2, Name = "Samsung Galaxy S23", Description = "Samsung Galaxy S23, 256GB, Phantom Black", ImageUrl = "galaxys23.jpg", Price = 750, IsActive = true, Stock = 80 },
                new Product { Id = 3, Name = "Google Pixel 7", Description = "Google Pixel 7, 128GB, Obsidian", ImageUrl = "pixel7.jpg", Price = 650, IsActive = true, Stock = 60 },
                new Product { Id = 4, Name = "OnePlus 11", Description = "OnePlus 11, 256GB, Titan Black", ImageUrl = "oneplus11.jpg", Price = 700, IsActive = true, Stock = 50 }
            }
        );
    }
}
