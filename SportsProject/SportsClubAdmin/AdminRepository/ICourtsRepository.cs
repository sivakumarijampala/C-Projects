using Models;

namespace SportClubProject.AdminRepository
{
    public interface ICourtsRepository
    {


        public IEnumerable<Courts> GetAllCourts();


        //get court by sport id
        public List<Courts> GetCourtBySportId(int sportId);

     

        //delete sport by id

        public Courts DeleteCourt(int id);

        //update sport 

        public Courts UpdateCourt(Courts court,int id);

        //save court
        public Courts SaveCourt(Courts court);

        //save court by sportid
        public Courts SaveCourtBySportId(int sportId, Courts courts);
    }
}
