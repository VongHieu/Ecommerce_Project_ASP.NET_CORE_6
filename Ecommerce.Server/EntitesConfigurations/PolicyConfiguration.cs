using Ecommerce.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Server.EntitesConfigurations
{
    public class PolicyConfiguration : IEntityTypeConfiguration<Policy>
    {
        public void Configure( EntityTypeBuilder<Policy> builder )
        {
            builder.ToTable("Tb_Policies");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Detail).IsRequired();
        }
    }
}
