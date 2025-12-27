using Microsoft.AspNetCore.Mvc;

namespace dotnet_hello_world_pipeline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Ok("Hello, World updated!");
        }
    }
}
