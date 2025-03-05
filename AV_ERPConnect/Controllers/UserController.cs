using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AV_ERP_DATA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// secured API for testing the JWT TOKEN
        /// </summary>
        /// <returns></returns>
        [HttpGet("profile")]
        [Authorize]
        public IActionResult profile()
        {
            return Ok("User Profile data");
        }
    }
}
