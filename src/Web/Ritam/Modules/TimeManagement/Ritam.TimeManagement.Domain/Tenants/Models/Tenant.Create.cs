using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Tenants.Events;

namespace Ritam.TimeManagement.Domain.Tenants.Models;
public partial class Tenant
{
    public Result<Tenant> Create(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Result.Invalid<Tenant>("name field required");
        }
        
        if (string.IsNullOrWhiteSpace(email))
        {
            return Result.Invalid<Tenant>("email field required");
        }

        Tenant tenant = new Tenant
        {
            Uid = Guid.NewGuid(),
            Name = name,
            Email = email
        };

        tenant.AddDomainEvent(new TenantCreatedDomainEvent(tenant));
        return Result.Ok(tenant);
    }
}
