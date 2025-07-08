using Ritam.Common.Domain;
using Ritam.Common.Result;

namespace Ritam.TimeManagement.Domain.Common.ValueObjects;
public class FirstNameValueObject : ValueObject
{
    public string Value { get; private set; }

    protected FirstNameValueObject(string value)
    {
        Value = value;
    }

    public static Result<FirstNameValueObject> Create(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            return Result.Invalid<FirstNameValueObject>(ResultCodes.FirstNameRequired);
        }

        if (firstName.Length < 2 || firstName.Length > 100)
        {
            return Result.Invalid<FirstNameValueObject>(ResultCodes.FirstNameInvalidLength);
        }

        return Result.Ok(new FirstNameValueObject(firstName));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value.ToLower();
    }

    public static implicit operator string(FirstNameValueObject firstName) => firstName.Value;
}
