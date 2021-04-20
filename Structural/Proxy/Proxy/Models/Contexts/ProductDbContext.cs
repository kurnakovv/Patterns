using System.Data.Entity;

namespace Proxy.Models.Contexts
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("productShop") { }
        public DbSet<Product> Products { get; set; }
    }
}
