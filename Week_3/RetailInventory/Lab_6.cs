using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

// --- Update a Product ---
var productToUpdate = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
if (productToUpdate != null)
{
    productToUpdate.Price = 70000;
    await context.SaveChangesAsync();
    Console.WriteLine("✅ Laptop price updated to ₹70000.");
}

// --- Delete a Product ---
var productToDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
if (productToDelete != null)
{
    context.Products.Remove(productToDelete);
    await context.SaveChangesAsync();
    Console.WriteLine("🗑️ Rice Bag deleted from the database.");
}
