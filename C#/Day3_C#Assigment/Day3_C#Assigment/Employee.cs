using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class Employee
    {
        string Name;
        int Salary;
        public Employee(String Name)
        {
         this.Name=Name;
         Console.WriteLine(Name);
        }
        public Employee(String Name, int Salary):this(Name) 
        {
            this.Salary=Salary;
            Console.WriteLine(Salary);
        }
        
    }
}
