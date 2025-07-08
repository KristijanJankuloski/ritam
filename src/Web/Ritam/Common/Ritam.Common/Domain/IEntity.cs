namespace Ritam.Common.Domain;
public interface IEntity<T> : IEntity
{
    public T Id { get; set; }

    public Guid Uid { get; set; }
}

public interface IEntity
{
    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? DeletedOn { get; set; }
}
