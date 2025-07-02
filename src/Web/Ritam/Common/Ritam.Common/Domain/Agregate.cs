namespace Ritam.Common.Domain;
public abstract class Agregate : Entity, IAgregate<long>
{
    public readonly List<IDomainEvent> _domainEvents = new();
    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public IDomainEvent[] ClearDomainEvents()
    {
        IDomainEvent[] dequeueEvents = _domainEvents.ToArray();
        _domainEvents.Clear();
        return dequeueEvents;
    }
}
