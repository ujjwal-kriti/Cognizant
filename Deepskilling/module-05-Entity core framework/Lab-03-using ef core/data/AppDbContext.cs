using Microsoft.EntityFrameworkCore;
using Lab_03_using_ef_core.Models;

namespace Lab_03_using_ef_core.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=RetailStoreDb;Trusted_Connection=True;TrustServerCertificate=True");
    }
}