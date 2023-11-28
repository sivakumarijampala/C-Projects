using Microsoft.EntityFrameworkCore;

namespace StudentCrudByUsingWebApiCore.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options){
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure 'login' entity as keyless
            modelBuilder.Entity<login>().HasNoKey();

            // Other configurations...

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<userDetails> UserDetails { get; set; }
        public DbSet<login> Logins { get; set; }
        
    }
}
