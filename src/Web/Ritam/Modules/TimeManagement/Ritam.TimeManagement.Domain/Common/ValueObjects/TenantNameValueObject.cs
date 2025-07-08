using Ritam.Common.Domain;
using Ritam.Common.Result;
using System.Xml.Linq;

namespace Ritam.TimeManagement.Domain.Common.ValueObjects;
public class TenantNameValueObject : ValueObject
{
    public string Value { get; private set; }

    protected TenantNameValueObject(string value)
    {
        Value = value;
    }

    public static Result<TenantNameValueObject> Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Result.Invalid<TenantNameValueObject>(ResultCodes.TenantNameRequired);
        }
        if (name.Length < 2 || name.Length > 150)
        {
            return Result.Invalid<TenantNameValueObject>(ResultCodes.TenantNameInvalid);
        }

        return Result.Ok(new TenantNameValueObject(name));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value;

    public static implicit operator string(TenantNameValueObject name) => name.Value;
}
