using System.Data.Entity;
namespace Beloglazoff.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Beloglazoff")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
