using Microsoft.AspNetCore.Mvc;
using dotnetdocker.Models; // Assuming your models are in a 'Models' namespace

namespace dotnetdocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("/hello")]
        public IActionResult GetHello()
        {
            var message = new Message { Text = "Hello" }; // Use 'Message' instead of 'message'
            return Ok(message);
        }
    }
}
