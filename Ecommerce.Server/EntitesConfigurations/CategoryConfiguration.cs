using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure( EntityTypeBuilder<Category> builder )
        {
            builder.ToTable("Tb_Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.SEOTitle).HasMaxLength(255);
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getutcdate()");
            builder.Property(x => x.SEOAlias).IsRequired().HasMaxLength(255).IsUnicode(false);

        }
    }
}
