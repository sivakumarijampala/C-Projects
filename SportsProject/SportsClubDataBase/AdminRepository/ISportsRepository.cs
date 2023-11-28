using Models;

namespace SportClubProject.AdminRepository
{
    public interface ISportsRepository
    {

        //get sports method
        public IEnumerable<Sports> GetAllSports();


        //get sport by stadiumid

        public List<Sports> GetSportByStadiumId(int stadiumId);

        //delete sport by id

        public Sports DeleteSport(int id);

        //update sport 

        public Sports UpdateSport(Sports sport,int id);

        //save sport
        public Sports SaveSport(Sports sport);

        //save sport by id
        public Sports SaveSportByStadiumId(int stadiumId, Sports sport);
    }
}
