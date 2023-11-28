
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.UserRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        public ICouponsRepo couponsRepository;

        public CouponsController(ICouponsRepo couponsRepository)
        {
            this.couponsRepository= couponsRepository;
        }

       
        [HttpGet("getcoupons")]
        public ActionResult<IEnumerable<Coupons>> GetAllCoupons()
        {
            return couponsRepository.GetAllCoupons().ToList();
        }


    }
}
