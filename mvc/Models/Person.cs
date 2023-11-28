using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base("MySqlConnection")
    {
        Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
    }

    public DbSet<Person> People { get; set; }
}

