
using Microsoft.AspNetCore.Mvc;
using SportClubProject.UserRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        public IPaymentRepo PaymentRepository { get; set; }
       public PaymentController(IPaymentRepo paymentRepository)
        {
            PaymentRepository = paymentRepository;
        }

        //validating mobile
        [HttpGet("verifymobilenumber")]
        public bool VerifyMobile(long MobileNumber)
        {
            return PaymentRepository.ValidateMobileNumber(MobileNumber);
        }

    }
}
