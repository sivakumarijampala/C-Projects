using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Stud
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<string> Programming { get; set; }


        public List<Stud> DispalyStudents()
        {
            return new List<Stud>()
            {
                new Stud(){Id=1,Name="siva",Email="siva@234",Programming=new List<string>(){"c","c++","java"}},
                 new Stud(){Id=2,Name="kumari",Email="sivakumai@234",Programming=new List<string>(){"c#","c++","java"}},
                  new Stud(){Id=3,Name="malliswari",Email="mallika@234",Programming=new List<string>(){".net","python","sql"}},


            };
        }

    }
}
