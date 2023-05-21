using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure( EntityTypeBuilder<Cart> builder )
        {
            builder.ToTable("Tb_Cart");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getutcdate()");

        }
    }
}
