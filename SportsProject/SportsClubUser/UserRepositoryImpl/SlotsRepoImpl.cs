using SportClubProject.Repository;
using SportClubProject.Services;

namespace SportClubProject.UserRepository
{
    public class SlotsRepoImpl:ISlotsRepo
    {
        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        /*public readonly UserService userService;*/
        public UserService userService = new UserService();


        public SlotsRepoImpl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
        /*    this.userService = userService;*/
        }



        //getting all slots
        public List<string> GetSlots(string SportName, string date, string CourtName)
        {
            return userService.GetSlots(SportName, date, CourtName);

        }

    }
}
