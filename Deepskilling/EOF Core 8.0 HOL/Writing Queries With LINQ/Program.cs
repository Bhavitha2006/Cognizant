using Microsoft.EntityFrameworkCore;
using RetailLINQQueries.Data;
using RetailLINQQueries.Models;

using var context = new AppDbContext();

// Insert sample data if database is empty
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
        },
        new Product
        {
            Name = "Mobile",
            Price = 25000,
            Category = electronics
        },
        new Product
        {
            Name = "Headphones",
            Price = 3000,
            Category = electronics
        });

    await context.SaveChangesAsync();
}

Console.WriteLine("Filtered Products (Price > 1000)");

var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

foreach (var item in filtered)
{
    Console.WriteLine($"{item.Name} - ₹{item.Price}");
}

Console.WriteLine();

Console.WriteLine("Product DTO");

var productDTOs = await context.Products
    .Select(p => new
    {
        p.Name,
        p.Price
    })
    .ToListAsync();

foreach (var item in productDTOs)
{
    Console.WriteLine($"{item.Name} - ₹{item.Price}");
}