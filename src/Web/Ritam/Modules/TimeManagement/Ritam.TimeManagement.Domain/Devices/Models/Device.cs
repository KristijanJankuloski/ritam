using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Events.Models;
using Ritam.TimeManagement.Domain.Tenants.Models;

namespace Ritam.TimeManagement.Domain.Devices.Models;
public partial class Device : Agregate
{
    public string? Name { get; private set; }

    public string? SerialId { get; private set; }

    public long TenantId { get; private set; }

    public virtual Tenant? Tenant { get; private set; }

    public ICollection<Event> Events { get; private set; } = [];
}
