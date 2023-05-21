using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure( EntityTypeBuilder<Order> builder )
        {
            builder.ToTable("Tb_Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Code).IsRequired().HasMaxLength(255).IsUnicode(false);
            builder.Property(x => x.Consignee).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(50);


        }
    }
}
