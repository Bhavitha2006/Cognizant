using Microsoft.EntityFrameworkCore;
using RetailUpdateDelete.Data;
using RetailUpdateDelete.Models;

using var context = new AppDbContext();

// Insert initial data if database is empty
if (!context.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    await context.Categories.AddRangeAsync(electronics, groceries);

    await context.Products.AddRangeAsync(
        new Product
        {
            Name = "Laptop",
            Price = 75000,
            Category = electronics
        },
        new Product
        {
            Name = "Rice Bag",
            Price = 1200,
            Category = groceries
        });

    await context.SaveChangesAsync();
}

// Update Product
var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");

if (product != null)
{
    product.Price = 70000;
    await context.SaveChangesAsync();
    Console.WriteLine("Laptop price updated.");
}

// Delete Product
var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");

if (toDelete != null)
{
    context.Products.Remove(toDelete);
    await context.SaveChangesAsync();
    Console.WriteLine("Rice Bag deleted.");
}

Console.WriteLine("\nRemaining Products:");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}