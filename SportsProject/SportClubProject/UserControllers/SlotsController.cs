
using Microsoft.AspNetCore.Mvc;
using SportClubProject.UserRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotsController : ControllerBase
    {

        public ISlotsRepo slotsRepository;
        public SlotsController(ISlotsRepo slotsRepository)
        {
            this.slotsRepository = slotsRepository;
        }



        //getting all slots from repository
        [HttpGet("getslots")]
        public List<string> GetAllSlots(string SportName, string Date, string CourtName)
        {
            return slotsRepository.GetSlots(SportName, Date, CourtName);
        }


    }
}
