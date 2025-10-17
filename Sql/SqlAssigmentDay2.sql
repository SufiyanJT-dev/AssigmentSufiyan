@@ -0,0 +1,36 @@
--Use Day2Assigment
--CREATE TABLE Employees (
--    EmployeeID INT PRIMARY KEY,
--    FirstName VARCHAR(50),
--    LastName VARCHAR(50),
--    Department VARCHAR(50),
--    Salary DECIMAL(10, 2),
--    HireDate DATE
--);
Create a table students and insert names in malayalam
	->CREATE TABLE Students (StudentID int primary Key identity(1,1), StudentName  nvarchar(50) NOT NULL)
	->insert into Students values('രാഹുൽ'),('അർജുൻ'),('ടിനു'),('ബിമൽ'),('ദിൽഷാദ്'),('നബീൽ');
Retrieve all employees who work in Sales, Marketing, or IT departments
	->Select * from Employees where Department='Sales' or Department= 'Marketing' or Department= 'IT'
Find all employees with salaries ranging from $50,000 to $75,000 (inclusive).
	->Select * from Employees where salary between 50000 and 75000
List all employees whose last name begins with the letter 'S'.
	->select * from Employees where LastName like 'S%'
Display all employees with exactly five letters in their first name.
	->select * from Employees where FirstName LIKE '_____'
Find employees whose last name starts with either 'B', 'R', or 'S'.
	->select  * from Employees where LastName Like  '[B,R,S]%'
Retrieve all employees whose first name begins with any letter from 'A' through 'M'.
	->Select * from Employees where FirstName LIKE '[A-M]%'
List employees whose last name doesn t start with a vowel (A, E, I, O, U),
	->select * from Employees WHERE  LastName LIKE '[^A,E,I,O,U]%'
Identify employees earning more than $80,000 annually. 
	->Select * from Employees where Salary>80000
Find employees who joined the company before 2020. 
	->Select * from Employees where YEAR(HireDate) < 2020
List all employees not named 'John' (first name).
	->select * from Employees  where FirstName !='John'
Identify Marketing department employees earning $60,000 or less who were hired after June 30, 2019.
	->Select * from Employees  Where Department='Marketing' and Salary <= 60000 and HireDate >'2019-06-30'
Find employees whose first name contains the letters 'an' anywhere and ends with 'e'.
	->select * from Employees where FirstName LIKE '%an%e';