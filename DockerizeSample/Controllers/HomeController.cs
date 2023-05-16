using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerizeSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/health-check")]
        public IActionResult HealthCheck()
        {
            return Ok($"Every Thing Is Ok, Current Time: {DateTime.Now}");
        }
    }
}
