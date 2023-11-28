using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerUser
{
    public class User
    {
        public string Hellouser(string user)
        {
            return "hello" + user;
        }


        public bool AuthenticateUser(string user,string password)
        {
            if (user=="sivakumari" && password == "siva@2000")
            {
                return true;
            }
            else
            {
                return false;
            }

                    
        }
        

        
    }
}
