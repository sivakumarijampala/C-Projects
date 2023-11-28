using System.ComponentModel.DataAnnotations;

namespace StudentCrudByUsingWebApiCore.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int StudentAge { get; set; }
        public double StudentFees { get; set; }

    }
}
