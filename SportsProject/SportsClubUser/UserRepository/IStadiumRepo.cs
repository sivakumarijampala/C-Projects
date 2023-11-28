using Models;

namespace SportClubProject.UserRepository
{
    public interface IStadiumRepo
    {

        public IEnumerable<Stadiums> GetAllStadiums();
    }
}
