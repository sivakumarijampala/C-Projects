
using Microsoft.AspNetCore.Mvc;
using Models;

using SportClubProject.UserRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {


        public ISportsRepo SportsRepository { get; set; }
      
        public SportsController(ISportsRepo sportsRepository)
        {
            this.SportsRepository = sportsRepository;
        }

        //getting sports from repository
        [HttpGet("getsports")]
        public ActionResult<IEnumerable<Sports>> GetAllSports()

        {
            
            return SportsRepository.GetAllSports().ToList();
        }

    }
}
