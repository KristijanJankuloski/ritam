using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ritam.Api.Controllers.TimeManagement;
[Route("api/tenats/{tenantUid:guid}/people")]
[ApiController]
public class PeopleController : BaseController
{
}
