using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class CartDetailConfiguration : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure( EntityTypeBuilder<CartDetail> builder )
        {
            builder.ToTable("Tb_CartDetail");
            builder.HasKey(x => new { x.Product_Id, x.Cart_Id });
            builder.HasOne(x => x.GetCart)
                .WithMany(x => x.cartDetails)
                .HasForeignKey(x => x.Cart_Id)
                .HasConstraintName("FK_CartDetail_Cart");

            builder.HasOne(x => x.GetProduct)
                .WithMany(x => x.cartDetails)
                .HasForeignKey(x => x.Product_Id)
                .HasConstraintName("FK_CartDetail_Product");
        }
    }
}
