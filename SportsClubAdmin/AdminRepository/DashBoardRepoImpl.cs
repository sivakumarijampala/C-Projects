using Models;
using SportClubProject.Repository;

namespace SportsClubAdmin.AdminRepository
{
    public class DashBoardRepoImpl : IDashBoardRepo
    {
        //sport db context
        private readonly SportsDbContext sportsDbContext;

        //logger
        private readonly ILogger<DashBoardRepoImpl> logger;

        //injecting sportsdbcontext and logger
        public DashBoardRepoImpl(SportsDbContext sportsDbContext, ILogger<DashBoardRepoImpl> logger)
        {
            this.sportsDbContext = sportsDbContext;
            this.logger = logger;
        }


        //get booking count
        public int BookingsCount()
        {
            try
            {
                logger.LogInformation("entered into bookings count method in dash board repo impl");
                int noofbookings = sportsDbContext.BookingDetails.Count();
                return noofbookings;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error occured while getting bookings count in dash board repo impl");
                throw;
            }
        }


        //get revenue
        public double RevenueGenerated()
        {
            try
            {
                logger.LogInformation("entered into revenue genarated method in dashboard repo impl  ");
                double totalprice = sportsDbContext.payments.Sum(e => e.Amount);
                return totalprice;
            }
            catch (Exception ex)
            {
                logger.LogError(ex,"error occured while genarating revenue");
                throw;

            }
        }


        //get users count
        public int UsersCount()
        {
            try
            {
                logger.LogInformation("entered into users count method in dashboard repo impl");
                int noofusers = sportsDbContext.UserDetails.Count();
                return noofusers;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"error occured while getting users count");
                throw;
            }
        }


        //get booking details
        public IEnumerable<BookingDetails> GetBookingDetails()
        {
            try
            {
                logger.LogInformation("entered into get booking details in dash board repo impl");
                return sportsDbContext.BookingDetails.ToList();
            }
            catch (Exception ex)
            {
                logger.LogError(ex,"error occur while getting booking details");
                throw;
            }
        }


        //get user details
        public IEnumerable<UserDetails> GetUserDetails()
        {
            try
            {
                logger.LogInformation("entered into get user details method in dash board repo impl");
                return sportsDbContext.UserDetails.ToList();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error occured while getting user details");
                throw;
            }
        }
    }
}
