using Microsoft.EntityFrameworkCore;
using Models;
using SportClubProject.Repository;

namespace SportClubProject.AdminRepository
{
    public class StadiumRepositoryImpl :IStadiumsRepository
    {

        private readonly SportsDbContext sportsDbContext;
        public StadiumRepositoryImpl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
        }

        //get all stadiums
        public IEnumerable<Stadiums> GetAllStadiums()
        {
            return sportsDbContext.Stadiums.Include(e=>e.Sports);
           
        }


        //save stadium
        public Stadiums SaveStadium(Stadiums stadium)
        {
            sportsDbContext.Add(stadium);
            sportsDbContext.SaveChanges();
            return stadium;
           
        }



        //delete stadium by id
        public Stadiums DeleteStadium(int stadiumId)
        {
            Stadiums stadium = sportsDbContext.Stadiums.Find(stadiumId);
            if (stadium != null)
            {
                sportsDbContext.Stadiums.Remove(stadium);
                sportsDbContext.SaveChanges();
            }
            return stadium;
        }
    }
}
