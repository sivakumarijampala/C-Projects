using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCrudByUsingWebApiCore.Jwt;
using StudentCrudByUsingWebApiCore.Models;

namespace StudentCrudByUsingWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public readonly IJwtService jwtService;
        public TokenController(IJwtService jwtService) {
            this.jwtService = jwtService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]login logindetails)
        {
            var token=jwtService.authenticate(logindetails.Email,logindetails.Password);
            if(string.IsNullOrEmpty(token))
            {
                return Unauthorized("user not found please register");
            }
            return Ok(token);
        }
    }
}
