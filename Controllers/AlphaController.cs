using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlphaController : ControllerBase
    {
        [HttpGet("get-message")]
        public IActionResult GetMessage()
        {
            return Ok(new {
                from = "alpha"
            });
        }

        // [HttpGet("connect-theta")]
        // public async Task<IActionResult> ConnectWithTheta()
        // {
        //     HttpClient httpClient = new();
        //     var result = await httpClient.GetAsync("http://127.0.0.1:8000/");
        //     var content = await result.Content.ReadAsStringAsync();
        //     return Ok(new
        //     {
        //         content
        //     });
        // }
    }
}
