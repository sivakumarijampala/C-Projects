using System.ComponentModel.DataAnnotations;

namespace StudentCrudByUsingWebApiCore.Models
{
    public class userDetails
    {
        [Key]
        public int userid { get; set; }
        public string username { get;set; }
        public string password { get; set; }
        public string email { get; set; }

        public string role { get; set; }
    }
}
