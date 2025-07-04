using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Events.Enums;
using Ritam.TimeManagement.Domain.Events.Events;

namespace Ritam.TimeManagement.Domain.Events.Models;
public partial class Event
{
    public static Result<Event> Create(DateTime occuredOn, long deviceId, EventType type)
    {
        Event @event = new Event
        {
            Uid = Guid.NewGuid(),
            OccuredOn = occuredOn,
            DeviceId = deviceId,
            Type = type
        };

        @event.AddDomainEvent(new EventCreatedDomainEvent(@event));
        return Result.Ok(@event);
    }
}
