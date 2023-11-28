using Models;

namespace SportClubProject.UserRepository
{
    public interface IBookingRepo
    {
        public IEnumerable<BookingDetails> GetAllBookingDetails();
    }
}
