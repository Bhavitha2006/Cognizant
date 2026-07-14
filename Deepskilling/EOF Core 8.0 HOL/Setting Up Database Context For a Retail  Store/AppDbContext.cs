using Microsoft.EntityFrameworkCore;
using RetailStoreDB.Models;

namespace RetailStoreDB.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=RetailStoreDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}