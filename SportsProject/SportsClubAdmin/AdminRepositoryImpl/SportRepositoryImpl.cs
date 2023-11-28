using Microsoft.EntityFrameworkCore;
using Models;
using SportClubProject.Repository;

namespace SportClubProject.AdminRepository
{
    public class SportRepositoryImpl:ISportsRepository
    {



        private readonly SportsDbContext sportsDbContext;

        public SportRepositoryImpl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
        }





        //get all sports

        public IEnumerable<Sports> GetAllSports()
        {
            return sportsDbContext.Sports.Include(x => x.Courts);
        }


        //get sport by stadiumid
        public List<Sports> GetSportByStadiumId(int stadiumId)
        {
            // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600
            Stadiums stadiums = sportsDbContext.Stadiums.Include(s => s.Sports).FirstOrDefault( stadium => stadium.StadiumId == stadiumId );
            List<Sports> sports = stadiums.Sports.ToList();
            return sports;
        }


        //save sport
        public Sports SaveSport(Sports sport)
        {
            sportsDbContext.Sports.Add(sport);
            sportsDbContext.SaveChanges();
            return sport;
        }


        public Sports SaveSportByStadiumId(int stadiumId, Sports sport)
        {
            Stadiums stadiums = sportsDbContext.Stadiums.Include(s => s.Sports).FirstOrDefault(stadium => stadium.StadiumId == stadiumId);
            if (stadiums == null)
            {
                throw new ArgumentException("Invalid stadium ID");
            }

 

            stadiums.StadiumId = stadiumId;
            stadiums.Sports.Add(sport);
            sportsDbContext.SaveChanges();
            return sport;

        }




        //delete sport by id
        public Sports DeleteSport(int id)
        {
            Sports sport = sportsDbContext.Sports.Find(id);
            if (sport != null)
            {
                sportsDbContext.Sports.Remove(sport);
                sportsDbContext.SaveChanges();
            }
            return sport;
        }



        //update sport
        
        public Sports UpdateSport(Sports sport, int id)
        {
            var existingSport = sportsDbContext.Sports.FirstOrDefault(s => s.SportId == id);
            if (existingSport != null)
            {
                existingSport.SportName = sport.SportName; 
                existingSport.SportImageUrl = sport.SportImageUrl;
                existingSport.SportName = sport.Status;
                sportsDbContext.SaveChanges();
            }
            return existingSport;
        }

    }
}

