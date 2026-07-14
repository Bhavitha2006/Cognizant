using System.Collections.Generic;

namespace RetailUpdateDelete.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}