

using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.UserRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        public IStadiumRepo StadiumsRepository { get; set; }
        public StadiumController(IStadiumRepo stadiumsRepository) { 
            this.StadiumsRepository = stadiumsRepository;
        }

        [HttpGet("getallstadiums")]
        public ActionResult<IEnumerable<Stadiums>> GetAllStadiums()

        {

            return StadiumsRepository.GetAllStadiums().ToList();
        }

    }
}
