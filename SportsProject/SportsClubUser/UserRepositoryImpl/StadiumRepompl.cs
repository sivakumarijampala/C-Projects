using Microsoft.EntityFrameworkCore;
using Models;
using SportClubProject.Repository;
using SportClubProject.Services;

namespace SportClubProject.UserRepository
{
    public class StadiumRepompl : IStadiumRepo
    {

        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;
        public UserService userService = new UserService();

        public StadiumRepompl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
        }
        public IEnumerable<Stadiums> GetAllStadiums()
        {
            //get all stadiums
                return sportsDbContext.Stadiums.Include(e => e.Sports);

            }
        }
    }

