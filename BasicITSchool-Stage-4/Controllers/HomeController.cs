using Microsoft.AspNetCore.Mvc;

namespace BasicITSchool_Stage_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpPost("byFilter")]
        public IActionResult Test()
        {
            return Ok();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
