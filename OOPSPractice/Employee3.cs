using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    public class Employee3
    {
        int eid;
        string name;
        double salary;
        public Employee3(int eid, string name, double salary)
        {
            this.eid = eid;
            this.name = name;
            this.salary = salary;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return eid;
                }
                else if (index == 1)
                {
                    return name;

                }
                else if (index == 2)
                {
                    return salary;
                }
                else
                {
                    return null;
                }


            }
            set
            {
                if (index == 0)
                {
                    eid = (int)value;
                }
                else if (index == 1)
                {
                    name = (string)value;

                }
                else if (index == 2)
                {
                    salary = (int)value;
                }


            }
        }

        public object this[string name1]
        {
            get
            {
                if (name1 == "eid")
                {
                    return eid;
                }
                else if (name1 == "name")
                {
                    return name;
                }
                else
                {
                    return salary;
                }
                
            }
            set
            {
                if (name1 == "eid")
                {
                    eid = (int)value;
                }
                else if (name1 == "name")
                {
                    name = (string) value;
                }
                else
                {
                    salary = (int) value;

                }
            }

        }

    }
}



        