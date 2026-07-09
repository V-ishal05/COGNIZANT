namespace RetailInventory.Models
{
    public class Product
    {
        // Primary Key
        public int Id { get; set; }

        // Product Name
        public string Name { get; set; } = string.Empty;

        // Product Price
        public decimal Price { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property
        public Category Category { get; set; } = null!;
    }
}