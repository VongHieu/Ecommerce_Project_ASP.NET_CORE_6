using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure( EntityTypeBuilder<Product> builder )
        {
            builder.ToTable("Tb_Products");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("getutcdate()");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Thumbnail).HasMaxLength(255).IsUnicode(false);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.Detail).HasMaxLength(int.MaxValue);
            builder.Property(p => p.SEOAlias).IsRequired().HasMaxLength(255).IsUnicode(false);
            builder.Property(p => p.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.ViewCount).HasDefaultValue(0);
            builder.Property(p => p.Price).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.OriginalPrice).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.Status).IsRequired().HasDefaultValue(true);

            builder.HasOne(p => p.GetProductCategory)
             .WithMany(p => p.products)
             .HasForeignKey(p => p.ProductCategory_Id)
             .HasConstraintName("FK_Product_ProductCategory");

            builder.HasOne(p => p.GetPromotion)
             .WithMany(p => p.products)
             .HasForeignKey(p => p.Promotion_Id)
             .HasConstraintName("FK_Product_Promotion");
        }
    }
}
