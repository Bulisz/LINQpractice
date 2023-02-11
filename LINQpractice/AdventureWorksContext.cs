using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LINQpractice;

public class AdventureWorksContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductSubcategory> ProductSubcategories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = localhost;Database = AdventureWorks2019;User Id = sa;Password = Password123!;TrustServerCertificate=True");

        optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }
}
