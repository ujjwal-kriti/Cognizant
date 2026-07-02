using System.Collections.Generic;

namespace Lab_02_set_up_database_context.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}