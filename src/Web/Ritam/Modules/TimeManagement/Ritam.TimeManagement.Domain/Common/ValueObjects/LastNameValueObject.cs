using Ritam.Common.Domain;
using Ritam.Common.Result;

namespace Ritam.TimeManagement.Domain.Common.ValueObjects;
public class LastNameValueObject : ValueObject
{
    public string Value { get; private set; }

    protected LastNameValueObject(string value)
    {
        Value = value;
    }

    public static Result<LastNameValueObject> Create(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
        {
            return Result.Invalid<LastNameValueObject>(ResultCodes.LastNameRequired);
        }

        if (lastName.Length < 2 || lastName.Length > 100)
        {
            return Result.Invalid<LastNameValueObject>(ResultCodes.LastNameInvalidLength);
        }

        return Result.Ok(new LastNameValueObject(lastName));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value.ToLower();
    }

    public static implicit operator string(LastNameValueObject lastName) => lastName.Value;
}
