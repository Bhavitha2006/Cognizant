using Microsoft.EntityFrameworkCore;
using RetailRetrieveData.Data;
using RetailRetrieveData.Models;

using var context = new AppDbContext();

// Insert sample data only if database is empty
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

Console.WriteLine("All Products");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

Console.WriteLine();

var product = await context.Products.FindAsync(1);

Console.WriteLine($"Found: {product?.Name}");

Console.WriteLine();

var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive: {expensive?.Name}");