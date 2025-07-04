using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Devices.Events;

namespace Ritam.TimeManagement.Domain.Devices.Models;
public partial class Device
{
    public static Result<Device> Create(string? name, string? serialId, long tenantId)
    {
        Device device = new Device
        {
            Uid = Guid.NewGuid(),
            Name = name,
            SerialId = serialId,
            TenantId = tenantId
        };

        device.AddDomainEvent(new DeviceCreatedDomainEvent(device));
        return Result.Ok(device);
    }
}
