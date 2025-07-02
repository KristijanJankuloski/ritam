using Ritam.Common.Domain;

namespace Ritam.TimeManagement.Domain.Models.Tenant;
public partial class Tenant : Agregate
{
    public string Name { get; private set; } = default!;

    public string Email { get; private set; } = default!;
}
