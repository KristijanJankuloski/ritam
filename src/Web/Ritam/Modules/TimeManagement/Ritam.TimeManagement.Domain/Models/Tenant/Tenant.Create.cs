using Ritam.Common.Result;

namespace Ritam.TimeManagement.Domain.Models.Tenant;
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

        return Result.Ok(tenant);
    }
}
