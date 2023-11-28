using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace sprotsclubcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpPost("save")]
       public HttpResponseMessage Post([FromBody] string mess )
        {
            return 
        }

    }
}
