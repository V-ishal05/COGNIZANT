//using Microsoft.EntityFrameworkCore;
//using RetailInventory.Data;

//using var context = new AppDbContext();

//// Retrieve all products
//var products = await context.Products.ToListAsync();

//Console.WriteLine("All Products:");
//Console.WriteLine("-----------------------");

//foreach (var product in products)
//{
//    Console.WriteLine($"{product.Name} - ₹{product.Price}");
//}
//}
//using Microsoft.EntityFrameworkCore;
//using RetailInventory.Data;

//using var context = new AppDbContext();

//// Find product by ID
//var product = await context.Products.FindAsync(1);

//if (product != null)
//{
//    Console.WriteLine($"Found Product: {product.Name}");
//}
//else
//{
//    Console.WriteLine("Product not found.");
//}
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// Find the first product whose price is greater than 50000
var expensiveProduct = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

if (expensiveProduct != null)
{
    Console.WriteLine($"Expensive Product: {expensiveProduct.Name}");
}
else
{
    Console.WriteLine("No expensive product found.");
}