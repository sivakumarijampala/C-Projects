using Models;
using SportClubProject.Repository;
using SportClubProject.Services;

namespace SportClubProject.UserRepository
{
    public class CartsRepoImpl:ICartsRepo
    {
        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        /* public readonly UserService userService;*/
        public UserService userService = new UserService();
        public CartsRepoImpl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
          /*  this.userService = userService;*/
        }

        public List<Cart> GetAllCarts(int userId)
        {
            return userService.GetAllCarts(userId);
        }
        public string SaveCart(Cart carts)
        {
            string result = userService.SaveCart(carts);

            return result;
        }


    }
}
