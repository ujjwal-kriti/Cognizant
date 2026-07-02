using System.Collections.Generic;

namespace Lab_05_reteiving_data_from_databse.Models;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<Product> Products { get; set; } = new();
}