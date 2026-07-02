using System.Collections.Generic;

namespace Lab_04_insert_initial_data.Models;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<Product> Products { get; set; } = new();
}