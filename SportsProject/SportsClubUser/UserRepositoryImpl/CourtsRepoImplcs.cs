using Models;
using SportClubProject.Repository;
using SportClubProject.Services;

namespace SportClubProject.UserRepository
{
    public class CourtsRepoImplcs:ICourtsRepo
    {

        
        public readonly SportsDbContext sportsDbContext;

        //user service

        /* public readonly UserService userService;*/
        public UserService userService = new UserService();

        public CourtsRepoImplcs(SportsDbContext sportsDbContext)
        {
           /* this.userService = userService;*/
            this.sportsDbContext = sportsDbContext;
        }

        //getting all courts
        public List<Courts> GetAllCourts(string SportName, string date)
        {
            return userService.GetCourts(SportName, date);
        }
    }
}
