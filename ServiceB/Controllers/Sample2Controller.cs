using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sample2Controller : ControllerBase
    {
        [HttpGet("service2")]
        public string Get()
        {
            return "serviceB";
        }
    }
}
