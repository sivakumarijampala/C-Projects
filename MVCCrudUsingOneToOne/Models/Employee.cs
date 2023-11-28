using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrudUsingOneToOne.Models
{
    public class Employee
    {
        [Key] 
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public int employeeAge { get;set; }
        public double employeeSalary { get; set; }
    }
}