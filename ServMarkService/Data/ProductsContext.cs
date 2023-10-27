using Microsoft.EntityFrameworkCore;
using ServMarkService.Models;

namespace ServMarkService.Data;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}