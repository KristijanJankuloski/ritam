using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ritam.Api.Controllers.TimeManagement;
[Route("api/tenants/{tenantUid:guid}/locations")]
[ApiController]
public class LocationsController : BaseController
{
}
