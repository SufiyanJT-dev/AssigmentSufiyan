CREATE TABLE: Creates an Employees table with columns for EmployeeID, FirstName, LastName, Department, and Salary.
NSERT: Adds three employee records to the table.
SELECT: Shows different ways to query data:
Select all columns and rows
Select specific columns
Select with a WHERE clause to filter results\
What is the purpose of the IDENTITY keyword in the CREATE TABLE statement?
Write a SELECT statement to retrieve only the FirstName and Salary of all employees.
How would you modify the existing UPDATE statement to give all employees in the IT department a 10% raise
Write a SELECT statement to find the highest salary in the Employees table.How would you add a new column named "HireDate" of type DATE to the Employees table?
Write an INSERT statement to add a new employee named "Sarah Brown" in the "Marketing" department with a salary of 72000.00.
 How would you modify the table to ensure that the Salary column cannot contain negative values?
How would you add a UNIQUE constraint to the Employees table to ensure that no two employees can have the same email address
Write an ALTER TABLE statement to add an "Email" column to the Employees table with a UNIQUE constraint that allows NULL values
--Create table Employees(EmployeeID int Primary Key Identity(1,1),FirstName Varchar(50) NOT NULL,LastName Varchar(50) NOT NULL,Department Varchar(50) NOT NULl,Salary int NOT NULL)
--INSERT INTO [dbo].[Employees] values('sufiyan',' J T','IT',10000);
--INSERT INTO [dbo].[Employees] values('Rahul','P','IT',10000),
--('Karthi','R','HR',10000)
--select * from [dbo].[Employees]
--select EmployeeId from  [dbo].[Employees]
--select FirstName,Salary From [dbo].[Employees]
--Update  [dbo].[Employees]
--set Salary=(Salary+(Salary*.10)) where Department ='IT'
--Select * from [dbo].[Employees]
--select Max(Salary) from [dbo].[Employees]  
--Alter Table [dbo].[Employees]
--ADD   HireDate DATETIME DEFAULT GETDATE();
--INSERT INTO [dbo].[Employees] values('Sarah','Brown','Marketing',72000,GETDATE() );
--Alter Table [dbo].[Employees]
--ADD CONSTRAINT Salary CHECK(Salary>=0)
--Alter Table [dbo].[Employees]
--ADD   Email Varchar(100) ;
--CREATE UNIQUE INDEX UQ_Employees_Email
--ON dbo.Employees (Email)
--WHERE Email IS NOT NULL;
