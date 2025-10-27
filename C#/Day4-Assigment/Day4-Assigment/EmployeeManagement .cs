using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assigment
{
    public  class EmployeeManagement
    {
        public static int  IdCounter ;
        public string ID { get; private set; }
        public string Name { get;  set; }
        public int Salary {  get; set; }
        public string EmployeeType {  get; set; }
        static EmployeeManagement()
        {
            IdCounter = 1000;
        }
        static int  NumEmp(int Idcounter)
        {
           
            return Idcounter-1000;
        }
        static string NextId(int Idcounter)
        {
            int NextID = Idcounter;
                
            return "EMP"+NextID;
        }
        
        public EmployeeManagement(string name,int salary,string employeetype)
        {
           Name = name;
            Salary = salary;
            EmployeeType = employeetype;
            ID = "EMP" + IdCounter++;
            Display();
        }
        public void Display()
        {
            Console.WriteLine(" id:"+ID+" Name : "+Name+" Salary "+Salary+ " EmployeeType "+EmployeeType);
            Console.WriteLine("Next avilable ID " + NextId(IdCounter));
            Console.WriteLine("Total Employee "+ NumEmp(IdCounter));
        }

    }
}
