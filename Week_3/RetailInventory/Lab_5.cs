using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

// Retrieve all products
var products = await context.Products.Include(p => p.Category).ToListAsync();
Console.WriteLine("All Products:");
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price} ({p.Category.Name})");
}

// Find product by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"\nProduct with ID=1: {product?.Name}");

// Find product by condition
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"\nExpensive Product: {expensive?.Name}");
