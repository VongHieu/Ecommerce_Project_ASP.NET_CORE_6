using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure( EntityTypeBuilder<ProductCategory> builder )
        {
            builder.ToTable("Tb_ProductCategories");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("getutcdate()");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Description).HasMaxLength(255);
            builder.Property(p => p.SEOTitle).HasMaxLength(255);
            builder.Property(p => p.SEOAlias).IsRequired().IsUnicode(false).HasMaxLength(255);

            builder.HasOne(p => p.GetCategory)
             .WithMany(p => p.productCategories)
             .HasForeignKey(p => p.Category_Id)
             .HasConstraintName("FK_ProductCategory_Category");

            builder.HasOne(p => p.GetPromotion)
             .WithMany(p => p.productCategories)
             .HasForeignKey(p => p.Promotion_Id)
             .HasConstraintName("FK_ProductCategory_Promotion");
        }
    }
}
