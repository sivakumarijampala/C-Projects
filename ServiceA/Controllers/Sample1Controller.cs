using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sample1Controller : ControllerBase
    {
        [HttpGet("service1")]
        public string Get() {
            return "service A";
        }
    }
}
