using Microsoft.EntityFrameworkCore;
using Lab_04_insert_initial_data.Models;

namespace Lab_04_insert_initial_data.Data;

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