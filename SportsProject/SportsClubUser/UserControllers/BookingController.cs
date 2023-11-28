using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.UserRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

         public IBookingRepo BookingRepository { get; set; }
        public BookingController(IBookingRepo bookingRepository)
        {
            BookingRepository = bookingRepository;
        }


        //getting all booking details from repository
        [HttpGet("getbookingdetais")]
        public ActionResult<IEnumerable<BookingDetails>> GetAllBookingDetails()
        {
            return BookingRepository.GetAllBookingDetails().ToList();
        }


    }
}
