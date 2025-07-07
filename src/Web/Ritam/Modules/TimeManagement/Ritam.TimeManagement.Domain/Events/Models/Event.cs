using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Devices.Models;
using Ritam.TimeManagement.Domain.Events.Enums;
using Ritam.TimeManagement.Domain.People.Models;

namespace Ritam.TimeManagement.Domain.Events.Models;
public partial class Event : Agregate
{
    public EventType Type { get; private set; }

    public DateTime OccuredOn { get; private set; }

    public string CardNumber { get; private set; } = string.Empty;

    public long DeviceId { get; private set; }

    public virtual Device? Device { get; private set; }

    public long PersonId { get; private set; }

    public virtual Person? Person { get; private set; }
}
