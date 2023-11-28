using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCrudByUsingWebApiCore.Models;

namespace StudentCrudByUsingWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public UserRepo UserRepo { get; set; }
        public UserController(UserRepo repo) {
        UserRepo = repo;
        }
        [HttpGet("/getallusers")]
        public IEnumerable<userDetails> GetAllUsers()
        {
           return UserRepo.GetAllUserDetails();
        }
    }
}
