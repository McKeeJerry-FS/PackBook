using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PackBook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Intentionally throwing an exception to test the error handling middleware
            throw new InvalidOperationException("This is a test exception from TestController");
        }
    }
}
