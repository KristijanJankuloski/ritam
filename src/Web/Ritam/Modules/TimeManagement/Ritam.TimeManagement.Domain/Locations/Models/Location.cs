using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Devices.Models;
using Ritam.TimeManagement.Domain.People.Models;
using Ritam.TimeManagement.Domain.Tenants.Models;

namespace Ritam.TimeManagement.Domain.Locations.Models;
public partial class Location : Agregate
{
    public string Name { get; private set; } = string.Empty;

    public string Address { get; private set; } =string.Empty;

    public long TenantId { get; private set; }

    public virtual Tenant? Tenant { get; set; }

    public ICollection<Device> Devices { get; private set; } = [];

    public ICollection<Person> People { get; private set; } = [];
}
