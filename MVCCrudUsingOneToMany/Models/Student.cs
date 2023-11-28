using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrudUsingOneToMany.Models
{
    public class Student
    {
        [Key]
        public int StudId { get; set; }
        public string StudName { get; set; }
        public int StudAge { get; set; }
        public int DeptId { get; set; }
        public Department Department { get; set; }
    }
}