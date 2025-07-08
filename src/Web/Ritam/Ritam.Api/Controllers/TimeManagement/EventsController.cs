using Microsoft.AspNetCore.Mvc;

namespace Ritam.Api.Controllers.TimeManagement;
[Route("api/tenants/{tenantUid:guid}/events")]
[ApiController]
public class EventsController : BaseController
{
}
