
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.Repository;

namespace SportClubProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        //userrepository impl
        private readonly IUserRepository userRepository;

   
        
        
        //injecting user repository impl
        public UserController(IUserRepository userRepository)
        {
          
            this.userRepository = userRepository;
        }



        
        
        [HttpPost("saveuser")]
        public UserDetails SaveUser(UserDetails user)
        {
             return userRepository.SaveUserDeatails(user);
        }

    }
}
