using RetailInventory.Models;

using var context = new AppDbContext();

// Create categories
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

// Add categories to context
await context.Categories.AddRangeAsync(electronics, groceries);

// Create products
var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

// Add products to context
await context.Products.AddRangeAsync(product1, product2);

// Save changes to database
await context.SaveChangesAsync();

Console.WriteLine("Data inserted successfully!");
