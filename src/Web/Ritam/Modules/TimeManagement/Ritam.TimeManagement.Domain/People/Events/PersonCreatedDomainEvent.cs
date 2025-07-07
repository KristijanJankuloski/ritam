using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.People.Models;

namespace Ritam.TimeManagement.Domain.People.Events;
public record class PersonCreatedDomainEvent(Person Person) : IDomainEvent
{
}
