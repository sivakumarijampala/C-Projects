using Models;
using SportClubProject.Repository;

namespace SportClubProject.UserRepository
{
    public class CartsRepoImpl:ICartsRepo
    {
        //sports dbcontext
        public readonly SportsDbContext sportsDbContext;

        //user service

        public readonly UserService userService;
        public CartsRepoImpl(SportsDbContext sportsDbContext, UserService userService)
        {
            this.sportsDbContext = sportsDbContext;
            this.userService = userService;
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
