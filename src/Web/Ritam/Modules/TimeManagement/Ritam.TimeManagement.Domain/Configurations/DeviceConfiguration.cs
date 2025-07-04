using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ritam.TimeManagement.Domain.Devices.Models;

namespace Ritam.TimeManagement.Domain.Configurations;
public class DeviceConfiguration : IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Uid).IsUnique();
        builder.HasQueryFilter(x => x.DeletedOn == null);

        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        builder.Property(x => x.SerialId).HasMaxLength(50).IsRequired();

        builder
            .HasOne(x => x.Tenant)
            .WithMany(x => x.Devices)
            .HasForeignKey(x => x.TenantId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
