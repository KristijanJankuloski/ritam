using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Devices.Models;
using Ritam.TimeManagement.Domain.Locations.Models;

namespace Ritam.TimeManagement.Domain.Tenants.Models;
public partial class Tenant : Agregate
{
    public string Name { get; private set; } = default!;

    public string Email { get; private set; } = default!;

    public ICollection<Device> Devices { get; private set; } = [];

    public ICollection<Location> Locations { get; set; } = [];
}
