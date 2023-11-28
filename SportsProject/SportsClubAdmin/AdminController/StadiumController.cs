using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.AdminRepository;
using Microsoft.Extensions.Logging;
using System;

namespace SportClubProject.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        private readonly IStadiumsRepository stadiumsRepository;
        private readonly ILogger<StadiumController> logger;

       
        public StadiumController(IStadiumsRepository stadiumsRepository, ILogger<StadiumController> logger)
        {
            this.stadiumsRepository = stadiumsRepository;
            this.logger = logger;
        }

        
        
        
        [HttpGet("getallstadiums")]
        public IEnumerable<Stadiums> GetAllStadiums()
        {
            try
            {
                IEnumerable<Stadiums> stadiums = stadiumsRepository.GetAllStadiums().ToList();
                return stadiums;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while retrieving all stadiums.");
                throw; // Rethrow the exception to the client
            }
        }

        
        
        
        [HttpPost("savestadium")]
        public Stadiums SaveStadium(Stadiums stadium)
        {
            try
            {
                if (stadium == null)
                {
                    throw new ArgumentNullException(nameof(stadium), "Stadium object is null.");
                }

                // Add more validation logic here if needed

                Stadiums stadiums = stadiumsRepository.SaveStadium(stadium);
                return stadiums;
            }
            catch (ArgumentNullException ex)
            {
                logger.LogError(ex, "The stadium object is null.");
                throw; // Rethrow the exception to the client
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while saving the stadium.");
                throw; // Rethrow the exception to the client
            }
        }

        
        [HttpDelete("deletestadium")]
        public Stadiums DeleteStadium(int stadiumId)
        {
            try
            {
                Stadiums stadiums = stadiumsRepository.DeleteStadium(stadiumId);
                return stadiums;
            }
            catch (ArgumentException ex)
            {
                logger.LogError(ex, $"Invalid stadium ID provided: {stadiumId}");
                throw; // Rethrow the exception to the client
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"An error occurred while deleting the stadium with ID {stadiumId}.");
                throw; // Rethrow the exception to the client
            }
        }
    }
}
