using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WepApiCrudUsingEntityFramework.Models
{
    public class StudentDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

    }
}