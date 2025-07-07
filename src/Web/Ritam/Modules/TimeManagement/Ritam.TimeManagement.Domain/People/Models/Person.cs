using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Events.Models;
using Ritam.TimeManagement.Domain.Locations.Models;

namespace Ritam.TimeManagement.Domain.People.Models;
public partial class Person : Agregate
{
    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public string CardNumber { get; private set; } = string.Empty;

    public long LocationId { get; set; }

    public virtual Location? Location { get; set; }

    public ICollection<Event> Events { get; private set; } = [];
}
