using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get;set; }
        public int EmpAge { get; set; }
        public double EmpSalary { get; set; }
        public string EmpDepartment { get; set; }

        public Employee(int empId, string empName, int empAge, double empSalary, string empDepartment)
        {
            EmpId = empId;
            EmpName = empName;
            EmpAge = empAge;
            EmpSalary = empSalary;
            EmpDepartment = empDepartment;
        }

        public object this[string name]
        {
            get
            {
                if (name == "EmpId")
                {
                    return EmpId;
                }
                else if(name == "EmpName")
                {
                    return EmpName;
                }
                else if(name == "EmpAge")
                {
                    return EmpAge;
                }
                else if (name == "EmpSalary")
                {
                    return EmpSalary;
                }
                else if(name == "EmpDepartment")
                {
                    return EmpDepartment;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (name == "EmpId")
                {
                    EmpId=Convert.ToInt32(value);
                }
                else if (name == "EmpName")
                {
                    EmpName = value.ToString();
                }
                else if((name == "EmpAge"))
                {
                    EmpAge=Convert.ToInt32(value);
                }
                else if (name == "EmpSalary")
                {
                    EmpSalary=Convert.ToInt32(value);
                }
                else if (name == "EmpDepartment")
                {
                    EmpDepartment = value.ToString();
                }
            }
        }

        public object this[int index]
        {
            get
            {
                if(index == 0)
                {
                    return EmpId;
                }
                else if(index == 1)
                {
                    return EmpName;
                }
                else if (index == 2)
                {
                    return EmpAge;
                }
                else if(index == 3){
                    return EmpSalary;
                }
                else if (index == 4)
                {
                    return EmpDepartment;
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
                    EmpId=Convert.ToInt32(value);
                }
                else if(index == 1){
                    EmpName = value.ToString();
                }
                else if(index == 2)
                {
                    EmpAge = Convert.ToInt32(value);
                }
                else if(index == 3)
                {
                    EmpSalary = Convert.ToInt32(value);
                }
                else if ( index == 4)
                {
                    EmpDepartment = value.ToString();
                }
            }
        }
    }
}
