using StudentCrudByUsingWebApiCore.Models;

namespace StudentCrudByUsingWebApiCore
{
    public interface UserRepo
    {
        public IEnumerable<userDetails> GetAllUserDetails();
    }
}
