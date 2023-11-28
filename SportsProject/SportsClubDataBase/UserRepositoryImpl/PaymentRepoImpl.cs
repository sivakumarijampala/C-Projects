using SportClubProject.Repository;
using SportClubProject.Services;

namespace SportClubProject.UserRepository
{
    public class PaymentRepoImpl:IPaymentRepo
    {
        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        public readonly UserService userService;
        public PaymentRepoImpl(SportsDbContext sportsDbContext, UserService userService)
        {
            this.sportsDbContext = sportsDbContext;
            this.userService = userService;
        }



        //checking mobile number is present or not
        public bool ValidateMobileNumber(long mobileNumber)
        {
            return userService.ValidateMobileNumber(mobileNumber);
        }
    }
}
