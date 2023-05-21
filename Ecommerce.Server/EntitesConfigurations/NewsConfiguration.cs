using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure( EntityTypeBuilder<News> builder )
        {
            builder.ToTable("Tb_News");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.SEOAlias).IsRequired().IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.Image).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Description).HasMaxLength(int.MaxValue);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("getutcdate()");
            builder.HasOne(x => x.GetCategory)
                .WithMany(x => x.news)
                .HasForeignKey(x => x.Category_Id)
                .HasConstraintName("FK_News_Category");

        }
    }
}
