using Microsoft.EntityFrameworkCore;
using RetailInsertData.Models;

namespace RetailInsertData.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=RetailInsertDataDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);
        }
    }
}