using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public static List<Student1> GetAllStudents()
        {
            return new List<Student1>()
            {
                new Student1() { Id = 1,Name="siva",Department="IT"},
                new Student1() {Id = 2,Name="kumari",Department="Hr" },
                new Student1() {Id = 3,Name="malliswari",Department="Hr" },
                new Student1() { Id = 4,Name="ram",Department="IT"},
                new Student1() { Id = 5,Name="lakshman",Department="IT"},


            };
        }
    }
}
