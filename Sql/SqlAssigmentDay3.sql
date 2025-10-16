// CREATED A DATABASE NAMED TESTDB
-> create database testDb;

// USING THE CREATED DATABASE 
-> use testDb;

// CREATING A TALBE NAME EMPLOYEE 
-> create table Employee(
EMPLOYEEID INT PRIMARY KEY IDENTITY(1,1),
FirstName NVARCHAR(100),
LastName NVARCHAR(100),
Department NVARCHAR(100),
Salary INT
);

// INSERTING 3 VALUES INTO THE EMPLOYEE TABLE 
-> insert into Employee values ('Rahul','P','IT',12000),('Sufiayn','J T','IT',12000),('John','c','HR',20000)
,

// selecting all Employees
-> select * from Employee;

// Select specific columns
-> select FirstName from Employee;

// Select with a WHERE clause to filter results\
-> select * from Employee where Department='IT';

// What is the purpose of the IDENTITY keyword in the CREATE TABLE statement?
-> To give a unique identity for each rows and it take in two parameters, in which the first parameter defines from where the id starts and the second one specifies the increment by which the value increment for each new rows 

// Write a SELECT statement to retrieve only the FirstName and Salary of all employees
-> select FirstName, Salary from Employee;

// How would you modify the existing UPDATE statement to give all employees in the IT department a 10% raise
-> update employee set salary = salary+(salary*0.10) where department='IT';

// Write a SELECT statement to find the highest salary in the Employees table
-> select Max(Salary) from Employee;

// How would you add a new column named "HireDate" of type DATE to the Employees table?
-> alter table Employee add HireDate Date;

// Write an INSERT statement to add a new employee named "Sarah Brown" in the "Marketing" department with a salary of 72000.00.
-> insert into Employee (FirstName, LastName, Department, Salary) values ('Sarah', 'Brow', 'Marketing', 72000.00);

// How would you modify the table to ensure that the Salary column cannot contain negative values?
-> alter table Employee add constraint check_salary check(salary >= 0);

// How would you add a UNIQUE constraint to the Employees table to ensure that no two employees can have the same email address
-> ALTER TABLE EMPLOYEE
ADD Email VARCHAR(255);

