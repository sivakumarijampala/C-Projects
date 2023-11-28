using System.ComponentModel.DataAnnotations;

namespace StudentAttendance.Models
{
    public class StudentAtt
    {
        [Key]
        public int StudentId { get; set; }  
        public string StudentName { get; set;}
        public double AttendancePercentage { get; set; }

    }
}
