using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ritam.TimeManagement.Domain.Events.Models;

namespace Ritam.TimeManagement.Domain.Configurations;
public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Uid).IsUnique();
        builder.HasQueryFilter(x => x.DeletedOn == null);

        builder
            .HasOne(x => x.Device)
            .WithMany(x => x.Events)
            .HasForeignKey(x => x.DeviceId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
