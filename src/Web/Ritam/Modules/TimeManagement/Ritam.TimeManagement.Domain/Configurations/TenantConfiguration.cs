using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ritam.TimeManagement.Domain.Tenants.Models;

namespace Ritam.TimeManagement.Domain.Configurations;
public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
{
    public void Configure(EntityTypeBuilder<Tenant> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Uid).IsUnique();
        builder.HasQueryFilter(x => x.DeletedOn == null);

        builder.Property(x => x.Name).HasMaxLength(150).IsRequired();
        builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
    }
}
