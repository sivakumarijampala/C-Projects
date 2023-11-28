
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.UserRepository;

namespace SportClubProject.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        public ICartsRepo CartsRepository { get; set; }
        public CartsController(ICartsRepo cartsRepository)
        {
            CartsRepository = cartsRepository;
        }


        // getallcarts
        [HttpGet("getcarts")]
        public ActionResult<List<Cart>> GetAllCarts(int userId)
        {
            return CartsRepository.GetAllCarts(userId).ToList();


        }


        //savecart
        [HttpPost("saveallcarts")]
        public string SaveCarts(Cart carts)
        {
            string result = CartsRepository.SaveCart(carts);
            return result;
        }
    }
}
