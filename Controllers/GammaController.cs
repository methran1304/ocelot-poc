using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class GammaController : ControllerBase
    {
        [HttpGet("get-message")]
        public IActionResult GetMessage()
        {
            return Ok(new
            {
                from = "gamma"
            });
        }
    }
}
