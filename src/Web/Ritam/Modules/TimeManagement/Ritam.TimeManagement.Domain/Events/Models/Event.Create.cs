using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Events.Enums;
using Ritam.TimeManagement.Domain.Events.Events;

namespace Ritam.TimeManagement.Domain.Events.Models;
public partial class Event
{
    private static Result<string> CreateCardNumberValue(string cardNumber)
    {
        if (string.IsNullOrEmpty(cardNumber))
        {
            return Result.Invalid<string>(ResultCodes.PersonFirstNameRequired);
        }

        if (cardNumber.Length < 2 || cardNumber.Length > 100)
        {
            return Result.Invalid<string>(ResultCodes.PersonFirstNameInvalidLength);
        }

        return Result.Ok(cardNumber);
    }

    public static Result<Event> Create(string cardNumber, long personId, DateTime occuredOn, long deviceId, EventType type)
    {
        Result<string> cardNumberValue = CreateCardNumberValue(cardNumber);
        if (cardNumberValue.IsFailure)
        {
            return Result.FromError<Event>(cardNumberValue);
        }

        Event @event = new Event
        {
            Uid = Guid.NewGuid(),
            CardNumber = cardNumberValue,
            OccuredOn = occuredOn,
            DeviceId = deviceId,
            PersonId = personId,
            Type = type
        };

        @event.AddDomainEvent(new EventCreatedDomainEvent(@event));
        return Result.Ok(@event);
    }
}
