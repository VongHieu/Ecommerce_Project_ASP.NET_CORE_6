using Ecommerce.Server.EntitesConfigurations;
using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
namespace Ecommerce.Server.EF
{
    public class EDbContext : DbContext
    {
        public EDbContext( DbContextOptions options ) : base(options)
        {

        }
        #region DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Advertisement> advertisements { get; set; }
        public DbSet<Promotion> promotions { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<CartDetail> cartDetails { get; set; }
        public DbSet<Policy> policies { get; set; }

        #endregion
        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new PolicyConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new NewsConfiguration());
            modelBuilder.ApplyConfiguration(new AdvertisementConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CartDetailConfiguration());
        }
    }
}
