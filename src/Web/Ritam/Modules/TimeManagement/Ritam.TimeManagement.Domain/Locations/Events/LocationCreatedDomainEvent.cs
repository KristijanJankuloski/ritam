using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Locations.Models;

namespace Ritam.TimeManagement.Domain.Locations.Events;
public record class LocationCreatedDomainEvent(Location Location) : IDomainEvent
{
}
