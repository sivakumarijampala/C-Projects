using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class student:IComparable
    {
        public int id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public int age
        {
            get;
            set;
        }
        public student(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            student other = (student)obj;
            return id == other.id && name == other.name && age == other.age;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + id.GetHashCode();
            hash = hash * 23 + (name != null ? name.GetHashCode() : 0);
            hash = hash * 23 + age.GetHashCode();
            return hash;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            if (obj is student otherStudent)
            {
                return this.age.CompareTo(otherStudent.age);
            }

            throw new ArgumentException("Object is not a student");
        }
    }
}
