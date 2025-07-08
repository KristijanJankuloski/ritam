using System.ComponentModel.DataAnnotations.Schema;

namespace Ritam.Common.Domain;
public abstract class Entity : IEntity<long>
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public Guid Uid { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? DeletedOn { get; set; }
}
