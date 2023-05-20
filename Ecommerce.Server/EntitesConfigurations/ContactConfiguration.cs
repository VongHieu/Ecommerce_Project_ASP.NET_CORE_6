using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure( EntityTypeBuilder<Contact> builder )
        {
            builder.ToTable("Tb_Contacts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Message).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(255).IsUnicode(false);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(255).IsUnicode(false);
            builder.Property(x => x.Email).IsRequired().HasDefaultValueSql("getutcdate()");

            builder.HasOne(x => x.GetCategory)
                .WithMany(x => x.contacts)
                .HasForeignKey(x => x.Category_Id)
                .HasConstraintName("FK_Contact_Category");

        }
    }
}
