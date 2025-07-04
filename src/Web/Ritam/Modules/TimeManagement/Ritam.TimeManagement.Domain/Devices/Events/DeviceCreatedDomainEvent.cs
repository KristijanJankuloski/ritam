using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Devices.Models;

namespace Ritam.TimeManagement.Domain.Devices.Events;
public record class DeviceCreatedDomainEvent(Device Device) : IDomainEvent
{
}
