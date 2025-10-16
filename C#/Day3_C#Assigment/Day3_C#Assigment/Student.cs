using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class Student
    {
        string Name;
        int Age;
        public Student()
        {
            Name = Name;
            Age = Age;
        }
        public void DisplayInfoStudent(String Name, int Age)
        {
            Console.WriteLine("Name of Student:" + Name + "And age:" + Age);
        }
        public static void Main(String[] args)
        {
            {
                Student obj = new Student();
                obj.DisplayInfoStudent("Anil", 30);
            }
        }
    }

}
