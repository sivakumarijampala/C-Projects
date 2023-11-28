

using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.AdminRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        public IStadiumsRepository StadiumsRepository { get; set; }
        public StadiumController(IStadiumsRepository stadiumsRepository) { 
            this.StadiumsRepository = stadiumsRepository;
        }

        [HttpGet("getallstadiums")]
        public ActionResult<IEnumerable<Stadiums>> GetAllStadiums()

        {

            return StadiumsRepository.GetAllStadiums().ToList();
        }

    }
}
