using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class grades
    {
        public int studid
        {
            get;
            set;
        }
        public  string course
        {
            get;
            set;
        }

        public string grade
        {
            get;
            set;
        }

        public grades(int studid,string course,string grade)
        {
            this.studid = studid;
            this.course = course;
            this.grade = grade;
        }
    }
}
