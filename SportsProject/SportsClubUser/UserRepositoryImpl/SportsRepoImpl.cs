using Microsoft.EntityFrameworkCore;
using Models;
using SportClubProject.Repository;
using SportClubProject.Services;

namespace SportClubProject.UserRepository
{
    public class SportsRepoImpl:ISportsRepo
    {
        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        /* public readonly UserService userService;*/
        public UserService userService = new UserService();
        public SportsRepoImpl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
           /* this.userService = userService;*/
        }




        //get sports 
        public IEnumerable<Sports> GetAllSports()
        {
            return sportsDbContext.Sports.Include(e => e.Courts).ToList();
        }

    }
}
