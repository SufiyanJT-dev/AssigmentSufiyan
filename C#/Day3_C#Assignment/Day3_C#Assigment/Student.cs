using System;

namespace Day3_C_Assignment
{
    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfoStudent()
        {
            Console.WriteLine($"Name of Student: "+ name+" Age:" +age);
        }

        public static void Main(string[] args)
        {
            Student obj = new Student("Anil", 30);
            obj.DisplayInfoStudent();
        }
    }
}
