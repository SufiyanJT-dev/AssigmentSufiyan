using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefac
{
    internal class Employee
    {
        public int Name {  get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public double bonus { get; set; }
        public double totalNewSalary { get; set; }
        public double CalculateTotalCompensation()
        {
            bonus = Salary * 0.1;
            totalNewSalary= Salary + bonus;
            return totalNewSalary;
        }

    }
}
