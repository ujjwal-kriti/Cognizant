using System.Collections.Generic;

namespace Lab_03_using_ef_core.Models;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<Product> Products { get; set; } = new();
}