using Ritam.Common.Domain;
using Ritam.TimeManagement.Domain.Tenants.Models;

namespace Ritam.TimeManagement.Domain.Tenants.Events;
public record TenantCreatedDomainEvent(Tenant Tenant) : IDomainEvent
{
}
