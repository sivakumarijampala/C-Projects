using Models;

namespace SportClubProject.UserRepository
{
    public interface ISportsRepo
    {
        public IEnumerable<Sports> GetAllSports();
    }
}
