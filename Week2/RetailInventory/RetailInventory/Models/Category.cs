using System.Collections.Generic;

namespace RetailInventory.Models
{
    public class Category
    {
        // Primary Key
        public int Id { get; set; }

        // Category Name
        public string Name { get; set; } = string.Empty;

        // Navigation Property
        public List<Product> Products { get; set; } = new List<Product>();
    }
}