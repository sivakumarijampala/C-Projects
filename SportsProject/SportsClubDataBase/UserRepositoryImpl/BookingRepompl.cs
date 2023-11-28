using Models;
using SportClubProject.Repository;

namespace SportClubProject.UserRepository
{
    public class BookingRepompl:IBookingRepo
    {


        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        public readonly UserService userService;

        public BookingRepompl(SportsDbContext sportsDbContext, UserService userService)
        {
            this.sportsDbContext = sportsDbContext;
            this.userService = userService;
        }




        //get all Booking details
        public IEnumerable<BookingDetails> GetAllBookingDetails()
        {
            return sportsDbContext.BookingDetails.ToList();
        }

    }
}
