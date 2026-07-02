using Microsoft.EntityFrameworkCore;
using Lab_05_reteiving_data_from_databse.Models;

namespace Lab_05_reteiving_data_from_databse.Data;

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