
using Microsoft.AspNetCore.Mvc;

using Twilio.Clients;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using SportsProject.Controllers;
using Models;

namespace SportClubProject.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsController : ControllerBase
    {

        private readonly ITwilioRestClient client;

        public SmsController(ITwilioRestClient twilioRest)
        {
            client = twilioRest;
        }
        [HttpPost("SendSms")]
        public int SendSms(Smsmodel smsmodel)
        {


            Random random = new Random();
            int otp = random.Next(100000, 999999);
            string otpmessage = smsmodel.Message;
            otpmessage = otpmessage + otp;
            smsmodel.Message = otpmessage;

            var message = MessageResource.Create(

                to: new PhoneNumber(smsmodel.To),
                from: new PhoneNumber(smsmodel.From),
                body: smsmodel.Message,
                client: client);

            return otp;
        }


        //sending booking details
        [HttpPost("sendBoking")]
        public bool SendBooking(Smsmodel smsmodel)
        {
            
            string otpmessage = smsmodel.Message;
    

            var message = MessageResource.Create(

                to: new PhoneNumber(smsmodel.To),
                from: new PhoneNumber(smsmodel.From),
                body: smsmodel.Message,
                client: client);

            return true;
        }



    }
}
