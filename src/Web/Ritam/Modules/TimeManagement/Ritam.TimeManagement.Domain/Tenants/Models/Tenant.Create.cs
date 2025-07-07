using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Tenants.Events;

namespace Ritam.TimeManagement.Domain.Tenants.Models;
public partial class Tenant
{
    private static Result<string> CreateNameValue(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Result.Invalid<string>(ResultCodes.TenantNameRequired);
        }
        if (name.Length < 2 || name.Length > 150)
        {
            return Result.Invalid<string>(ResultCodes.TenantNameInvalid);
        }

        return Result.Ok(name);
    }

    private static Result<string> CreateEmailValue(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return Result.Invalid<string>(ResultCodes.TenantEmailRequired);
        }
        if (!email.Contains("@") || email.Length < 3 || email.Length > 200)
        {
            return Result.Invalid<string>(ResultCodes.TenantEmailInvalid);
        }

        return Result.Ok(email);
    }

    public Result<Tenant> Create(string name, string email)
    {
        Result<string> nameValue = CreateNameValue(name);
        if (nameValue.IsFailure)
        {
            return Result.FromError<Tenant>(nameValue);
        }
        Result<string> emailValue = CreateEmailValue(email);
        if (emailValue.IsFailure)
        {
            return Result.FromError<Tenant>(emailValue);
        }

        Tenant tenant = new Tenant
        {
            Uid = Guid.NewGuid(),
            Name = nameValue.Value,
            Email = emailValue.Value
        };

        tenant.AddDomainEvent(new TenantCreatedDomainEvent(tenant));
        return Result.Ok(tenant);
    }
}
