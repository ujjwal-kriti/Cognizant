using Lab_05_reteiving_data_from_databse.Data;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

// Retrieve all products
var products = await context.Products.ToListAsync();

Console.WriteLine("All Products:");
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

// Find by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {product?.Name}");

// First product with Price > 50000
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive: {expensive?.Name}");