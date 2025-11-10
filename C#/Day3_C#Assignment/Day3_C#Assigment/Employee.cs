using System;

namespace Day3_C_Assignment
{
    public class Employee
    {
        private string _name;
        private int _salary;

        public Employee(string name)
        {
            _name = name;
            Console.WriteLine(_name);
        }

        public Employee(string name, int salary) : this(name)
        {
            _salary = salary;
            Console.WriteLine(_salary);
        }
    }
}
