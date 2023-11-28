using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCrudUsingOneToMany.Models
{
    public class StudentDepartmentDBContext:DbContext
    {
      public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        
    }
}