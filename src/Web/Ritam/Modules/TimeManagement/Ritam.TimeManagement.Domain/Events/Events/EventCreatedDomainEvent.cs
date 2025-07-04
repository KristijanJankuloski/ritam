using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Events.Models;

namespace Ritam.TimeManagement.Domain.Events.Events;
public record class EventCreatedDomainEvent(Event Event) : IDomainEvent
{
}
