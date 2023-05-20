using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure( EntityTypeBuilder<OrderDetail> builder )
        {
            builder.ToTable("Tb_OrderDetails");
            builder.HasKey(x => new { x.Order_Id, x.Product_Id });
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();

            builder.HasOne(x => x.GetOrder)
                .WithMany(x => x.orderDetails)
                .HasForeignKey(x => x.Order_Id)
                .HasConstraintName("FK_OrderDetail_Order");

            builder.HasOne(x => x.GetProduct)
                .WithMany(x => x.orderDetails)
                .HasForeignKey(x => x.Product_Id)
                .HasConstraintName("FK_OrderDetail_Product");

        }
    }
}
