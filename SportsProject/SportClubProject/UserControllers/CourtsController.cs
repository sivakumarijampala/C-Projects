
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.UserRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtsController : ControllerBase
    {
        public ICourtsRepo CourtsRepository { get; set; }
        public CourtsController(ICourtsRepo courtsRepository)
        {
            CourtsRepository = courtsRepository;
        }



        //getting all courts from repository
        [HttpGet("getcourts")]
        public List<Courts> GetAllCourts(string SportName, string Date)
        {
            return CourtsRepository.GetAllCourts(SportName, Date).ToList();
        }
    }
}
