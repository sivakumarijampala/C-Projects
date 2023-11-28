using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserDetails
    {

        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }


        public string Useremail { get; set; }

        public string password { get; set; }
        public long Usermobile { get; set; }
        public int Userage { get; set; }
        public string Usergender { get; set; }
    }
}
