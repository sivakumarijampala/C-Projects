
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.AdminRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {


        public ISportsRepository SportsRepository { get; set; }
        public SportsController(ISportsRepository sportsRepository)
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
