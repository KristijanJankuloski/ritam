using Ritam.Common.Domain;
using Ritam.Common.Result;

namespace Ritam.TimeManagement.Domain.Common.ValueObjects;
public class CardNumberValueObject : ValueObject
{
    public string Value { get; private set; }

    protected CardNumberValueObject(string value)
    {
        Value = value;
    }

    public static Result<CardNumberValueObject> Create(string cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
        {
            return Result.Invalid<CardNumberValueObject>(ResultCodes.CardNumberRequired);
        }

        if (cardNumber.Length < 2 || cardNumber.Length > 100)
        {
            return Result.Invalid<CardNumberValueObject>(ResultCodes.CardNumberInvalidLength);
        }

        return Result.Ok(new CardNumberValueObject(cardNumber));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator string(CardNumberValueObject cardNumber) => cardNumber.Value;
}
