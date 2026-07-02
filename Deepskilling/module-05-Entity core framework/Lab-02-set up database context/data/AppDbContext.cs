using Microsoft.EntityFrameworkCore;
using Lab_02_set_up_database_context.Models;

namespace Lab_02_set_up_database_context.Data;

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