using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments21_10_2025
{
    public class MenuBasedListProgram
    {
        List<Employee> employees = new List<Employee>();
        public void RemoveEmployee()
        {
            Console.Write("Enter  Employee Name to Be removed:");
            string? name = Console.ReadLine();
            employees.RemoveAll(employees=>employees.Name == name);
        }        
      public void AddEmployee()
        {
            Console.Write("Enter new  Employee Name:");
            string? name = Console.ReadLine();
            Console.Write("Enter the employee salary:");
            string? stringsalary = Console.ReadLine();
            if (double.TryParse(stringsalary, out double salary))
            {
                Console.Write("Enter the Employee type(P/C):");

                string EmployeeType = Console.ReadLine();
                employees.Add(new Employee(name, salary, EmployeeType));
            }      
        }
        public void DisplayEmployee()
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine("Employee Id " + e.Id + " Employee Name " + e.Name + " Employee salary " + e.Salary + "Employee Type" + e.EmployeeType);
            }
        }
        public void SearchEmployee() {
            Console.Write("Enter   Employee Name to be searched :");
            string? name = Console.ReadLine();
            var searchemployee=employees.Find(employees=>employees.Name == name);
            if (searchemployee != null) {
                Console.WriteLine(" found");
                Console.WriteLine($"ID: {searchemployee.Id}, Name: {searchemployee.Name}, Salary: {searchemployee.Salary}, Type: {searchemployee.EmployeeType}");
            }
            else
            {
                Console.WriteLine("Not found ");
            }
        }
    }
    public class Employee
    {
        public  string Id {  get; set; }
        public string Name {  get; set; }
        public double Salary {  get; set; }
        public static int id=0;
        public string EmployeeType {  get; set; }
        public Employee(string name,double salary,string employeetype) {
            
            Name = name;
            Salary=salary;
            EmployeeType = employeetype;

            Id = "EMP" +( 1000+id);
            id++;
        }
    }
}
