using Microsoft.AspNetCore.Mvc;
using SocialSync.Helpers;

namespace SocialSync.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {}
}
