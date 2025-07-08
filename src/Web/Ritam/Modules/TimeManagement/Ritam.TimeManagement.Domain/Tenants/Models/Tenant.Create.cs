using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Common.ValueObjects;
using Ritam.TimeManagement.Domain.Tenants.Events;

namespace Ritam.TimeManagement.Domain.Tenants.Models;
public partial class Tenant
{
    public Result<Tenant> Create(string name, string email)
    {
        Result<TenantNameValueObject> nameValue = TenantNameValueObject.Create(name);
        if (nameValue.IsFailure)
        {
            return Result.FromError<Tenant>(nameValue);
        }
        Result<EmailValueObject> emailValue = EmailValueObject.Create(email);
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
