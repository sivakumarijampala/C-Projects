using System.ComponentModel.DataAnnotations;

namespace StudentAdmision.Models
{
    public class StudentAd
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public string StudentClass { get; set; }
        public DateTime DateOfJoining { get; set; }


    }
}
