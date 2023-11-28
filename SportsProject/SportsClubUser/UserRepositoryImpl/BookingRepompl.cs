
using Models;
using SportClubProject.Repository;
using SportClubProject.Services;

namespace SportClubProject.UserRepository
{
    public class BookingRepompl:IBookingRepo
    {


        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        public  UserService userService = new UserService();

        public BookingRepompl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
           /* this.userService = userService;*/
        }




        //get all Booking details
        public IEnumerable<BookingDetails> GetAllBookingDetails()
        {
            return sportsDbContext.BookingDetails.ToList();
        }

    }
}
