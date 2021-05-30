using Microsoft.AspNetCore.Mvc;
using Tonder.Helpers;

namespace Tonder.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}
