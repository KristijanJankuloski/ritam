using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Locations.Events;

namespace Ritam.TimeManagement.Domain.Locations.Models;
public partial class Location
{
    private static Result<string> CreateNameValue(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result.Invalid<string>(ResultCodes.LocationNameRequired);
        }

        if (name.Length < 2 || name.Length > 100)
        {
            return Result.Invalid<string>(ResultCodes.LocationNameInvalidLength);
        }

        return Result.Ok(name);
    }

    private static Result<string> CreateAddressValue(string address)
    {
        if (string.IsNullOrEmpty(address))
        {
            return Result.Invalid<string>(ResultCodes.LocationAddressRequired);
        }

        if (address.Length < 2 || address.Length > 250)
        {
            return Result.Invalid<string>(ResultCodes.LocationAddressInvalidLength);
        }

        return Result.Ok(address);
    }

    public static Result<Location> Create(string name, string address, long tenantId)
    {
        Result<string> nameValue = CreateNameValue(name);
        if (nameValue.IsFailure)
        {
            return Result.FromError<Location>(nameValue);
        }
        Result<string> addressValue = CreateAddressValue(address);
        if (addressValue.IsFailure)
        {
            return Result.FromError<Location>(addressValue);
        }

        Location location = new Location
        {
            Uid = Guid.NewGuid(),
            Name = name,
            Address = address,
            TenantId = tenantId
        };

        location.AddDomainEvent(new LocationCreatedDomainEvent(location));
        return Result.Ok(location);
    }
}
