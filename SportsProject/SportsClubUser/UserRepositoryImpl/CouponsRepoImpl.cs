using Models;
using SportClubProject.Repository;
using SportClubProject.Services;

namespace SportClubProject.UserRepository
{
    public class CouponsRepoImpl:ICouponsRepo
    {

        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        /*public readonly UserService userService;*/
        public UserService userService = new UserService();
        public CouponsRepoImpl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
           /* this.userService = userService;*/
        }



        //getting all coupons
        public IEnumerable<Coupons> GetAllCoupons()
        {
            return sportsDbContext.Coupons.ToList();
        }


    }
}
