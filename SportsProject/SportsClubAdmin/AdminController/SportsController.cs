
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.AdminRepository;


namespace SportClubProject.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {


        //sport repository
        private readonly ISportsRepository sportsRepository;

        public SportsController(ISportsRepository sportsRepository)
        {
            this.sportsRepository = sportsRepository;
        }




        //get all sports
        [HttpGet("getallsports")]
        public IEnumerable<Sports> GetAllSports()
        {
            IEnumerable<Sports> sports = sportsRepository.GetAllSports().ToList();
            return sports;
        }

        //get sportby stadium id
        [HttpGet("getsportbystadiumid")]
        public IEnumerable<Sports> GetSportByStadiumId(int stadiumId)
        {
            IEnumerable<Sports> sports = sportsRepository.GetSportByStadiumId(stadiumId);
            return sports;
        }


        //save sport
        [HttpPost("savespost")]
        public Sports SaveSport(Sports sports)
        {
            Sports sport = sportsRepository.SaveSport(sports);
            return sport;
        }

        //delete sport
        [HttpDelete("deletespost")]
        public Sports DeletePost(int id)
        {
            Sports sports = sportsRepository.DeleteSport(id);
            return sports;
        }


        [HttpPost("savesportbystadiumid")]
        public IActionResult SaveSportByStadiumId(int stadiumId, [FromBody] Sports sport)
        {
            try
            {
                // Call the repository method to save the sport by stadium ID
                var savedSport = sportsRepository.SaveSportByStadiumId(stadiumId, sport);
                return Ok(savedSport);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }





        //update sport
        [HttpPut("updatesport")]
        public Sports UpdateSport(Sports sport,int id)
        {
            Sports sports = sportsRepository.UpdateSport(sport,id);
            return sports;

        }

        
    }
}
