
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.AdminRepository;


namespace SportClubProject.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtsController : ControllerBase
    {




        //sport repository
        private readonly ICourtsRepository courtsRepository;

        public CourtsController(ICourtsRepository courtsRepository)
        {
            this.courtsRepository = courtsRepository;
        }




        //get all sports
        [HttpGet("getallcourts")]
        public IEnumerable<Courts> GetAllCourts()
        {
            IEnumerable<Courts> courts= courtsRepository.GetAllCourts().ToList();
            return courts;
        }



        //get court sport id
        [HttpGet("getcourtbysportid")]
        public IEnumerable<Courts> GetCourtBySportId(int sportId)
        {
            IEnumerable<Courts> courts = courtsRepository.GetCourtBySportId(sportId);
            return courts;
        }


        //save sport
        [HttpPost("savecourt")]
        public Courts SaveCourt(Courts court)
        {
            Courts courts = courtsRepository.SaveCourt(court);
            return courts;
        }



        [HttpPost("savecourtbysportid")]
        public IActionResult SaveCourtBySportId(int sportId, [FromBody] Courts court)
        {
            try
            {
                // Call the repository method to save the sport by stadium ID
                var savedCourt = courtsRepository.SaveCourtBySportId(sportId, court);
                return Ok(savedCourt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //delete sport
        [HttpDelete("deletecourt")]
        public Courts DeleteCourt(int id)
        {
            Courts court = courtsRepository.DeleteCourt(id);
            return court;
        }


        //update sport
        [HttpPut("updatecourt")]
        public Courts UpdateCourt(Courts court,int id)
        {
            Courts courts=courtsRepository.UpdateCourt(court,id);
            return courts;

        }

        }

    }


