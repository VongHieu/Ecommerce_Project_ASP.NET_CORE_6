using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure( EntityTypeBuilder<Advertisement> builder )
        {
            builder.ToTable("Tb_Advertisements");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Link).HasMaxLength(255).IsUnicode(false);
            builder.Property(x => x.Image).HasMaxLength(255).IsRequired().IsUnicode(false);
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getutcdate()");
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(true);
            builder.HasOne(x => x.GetProductCategory)
                .WithMany(x => x.advertisements)
                .HasForeignKey(x => x.ProductCategory_Id)
                .HasConstraintName("FK_Advertisement_ProductCategory");

        }
    }
}
