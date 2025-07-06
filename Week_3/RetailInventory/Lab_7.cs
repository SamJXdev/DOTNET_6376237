using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

// --- Filter products with price > 1000 and sort by price descending ---
var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .Include(p => p.Category)
    .ToListAsync();

Console.WriteLine("📦 Filtered & Sorted Products:");
foreach (var p in filtered)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price} ({p.Category.Name})");
}

// --- Project into DTO (anonymous object with Name & Price only) ---
var productDTOs = await context.Products
    .Select(p => new { p.Name, p.Price })
    .ToListAsync();

Console.WriteLine("\n📄 Product DTOs (Name & Price only):");
foreach (var dto in productDTOs)
{
    Console.WriteLine($"🛒 {dto.Name} - ₹{dto.Price}");
}
