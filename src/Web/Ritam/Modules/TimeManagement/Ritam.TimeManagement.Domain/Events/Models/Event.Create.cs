using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Common.ValueObjects;
using Ritam.TimeManagement.Domain.Events.Enums;
using Ritam.TimeManagement.Domain.Events.Events;

namespace Ritam.TimeManagement.Domain.Events.Models;
public partial class Event
{
    public static Result<Event> Create(string cardNumber, long personId, DateTime occuredOn, long deviceId, EventType type)
    {
        Result<CardNumberValueObject> cardNumberValue = CardNumberValueObject.Create(cardNumber);
        if (cardNumberValue.IsFailure)
        {
            return Result.FromError<Event>(cardNumberValue);
        }

        Event @event = new Event
        {
            Uid = Guid.NewGuid(),
            CardNumber = cardNumberValue.Value,
            OccuredOn = occuredOn,
            DeviceId = deviceId,
            PersonId = personId,
            Type = type
        };

        @event.AddDomainEvent(new EventCreatedDomainEvent(@event));
        return Result.Ok(@event);
    }
}
