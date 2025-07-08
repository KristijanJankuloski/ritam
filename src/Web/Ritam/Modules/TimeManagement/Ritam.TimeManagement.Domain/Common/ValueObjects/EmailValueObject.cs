using Ritam.Common.Domain;
using Ritam.Common.Result;
using System.Text.RegularExpressions;

namespace Ritam.TimeManagement.Domain.Common.ValueObjects;
public class EmailValueObject : ValueObject
{
    public string Value { get; private set; }

    protected EmailValueObject(string value)
    {
        Value = value;
    }

    public static Result<EmailValueObject> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Result.Invalid<EmailValueObject>(ResultCodes.EmailRequired);

        if (value.Length < 3 || value.Length > 200 || !Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            return Result.Invalid<EmailValueObject>(ResultCodes.EmailInvalid);

        return Result.Ok(new EmailValueObject(value));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value.ToLower();
    }

    public override string ToString() => Value;

    public static implicit operator string(EmailValueObject email) => email.Value;
}
