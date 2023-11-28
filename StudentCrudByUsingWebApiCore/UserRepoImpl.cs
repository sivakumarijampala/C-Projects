using StudentCrudByUsingWebApiCore.Models;

namespace StudentCrudByUsingWebApiCore
{
    public class UserRepoImpl : UserRepo
    {
        public StudentDbContext Context { get; set; }
        public UserRepoImpl(StudentDbContext context)
        {
            Context = context;
        }
        public IEnumerable<userDetails> GetAllUserDetails()
        {
             return Context.UserDetails.ToList();
            
        }
    }
}
