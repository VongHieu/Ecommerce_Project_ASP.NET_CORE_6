using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure( EntityTypeBuilder<Promotion> builder )
        {
            builder.ToTable("Tb_Promotions");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Details).HasMaxLength(int.MaxValue);
            builder.Property(p => p.FromDate).IsRequired();
            builder.Property(p => p.ToDate).IsRequired();
            builder.Property(p => p.PercentageDiscount).IsRequired();
            builder.Property(p => p.Status).IsRequired().HasDefaultValue(true);

        }
    }
}
