using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ritam.TimeManagement.Domain.People.Models;

namespace Ritam.TimeManagement.Domain.Configurations;
public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Uid).IsUnique();
        builder.HasQueryFilter(x => x.DeletedOn == null);

        builder.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(100).IsRequired();
        builder.Property(x => x.CardNumber).HasMaxLength(100).IsRequired();

        builder
            .HasOne(x => x.Location)
            .WithMany(x => x.People)
            .HasForeignKey(x => x.LocationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
