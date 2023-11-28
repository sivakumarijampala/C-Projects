

using Microsoft.EntityFrameworkCore;
using Models;
using SportClubProject.Services;

namespace SportClubProject.Repository
{
    public class UserRepositoryImpl : IUserRepository

    {

        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        public readonly UserService userService;

        

        // Constructor injection with both dependencies
        public UserRepositoryImpl(UserService userService, SportsDbContext sportsDbContext)
        {
            this.userService = userService;
            this.sportsDbContext = sportsDbContext;
        }


       
        public UserDetails SaveUserDeatails(UserDetails userDetails)
        {
            userService.Savedetails(userDetails);
            return userDetails;
        }
    }
}
