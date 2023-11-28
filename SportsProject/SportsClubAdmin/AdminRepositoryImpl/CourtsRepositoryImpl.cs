using Microsoft.EntityFrameworkCore;
using Models;
using SportClubProject.Repository;

namespace SportClubProject.AdminRepository
{
    public class CourtsRepositoryImpl:ICourtsRepository
    {

       private readonly SportsDbContext sportsDbContext;

        public CourtsRepositoryImpl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
        }



        //get all courts

        public IEnumerable<Courts> GetAllCourts()
        {
            return sportsDbContext.Courts.ToList();
        }



        //get court by sport id

        public List<Courts> GetCourtBySportId(int sportId)
        {
            // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600
            Sports sports = sportsDbContext.Sports.Include(s => s.Courts).FirstOrDefault(sport => sport.SportId == sportId);
            List<Courts> courts = sports.Courts.ToList();
            return courts;
        }


        //save court
        public Courts SaveCourt(Courts court)
        {
            sportsDbContext.Courts.Add(court);
            sportsDbContext.SaveChanges();
            return court;
        }

        //save court by sport id
        public Courts SaveCourtBySportId(int sportId, Courts court)
        {
            Sports sports = sportsDbContext.Sports.Include(s => s.Courts).FirstOrDefault(sport => sport.SportId == sportId);
           



            sports.SportId = sportId;
            sports.Courts.Add(court);
            sportsDbContext.SaveChanges();
            return court;

        }


        //delete court
        public Courts DeleteCourt(int id)
        {
            Courts court = sportsDbContext.Courts.Find(id);
            if (court != null)
            {
                sportsDbContext.Courts.Remove(court);
                sportsDbContext.SaveChanges();
            }
            return court;
        }



        //update court
        public Courts UpdateCourt(Courts court,int CourtId)
        {
            var existingCourt = sportsDbContext.Courts.FirstOrDefault(s => s.CourtId == CourtId);
            if (existingCourt != null)
            {
                existingCourt.CourtsName = court.CourtsName;
                existingCourt.CourtImageUrl = court.CourtImageUrl ;
                existingCourt.CourtPrice = court.CourtPrice;
                sportsDbContext.SaveChanges();
            }
            return existingCourt;
        }
    }

    }



