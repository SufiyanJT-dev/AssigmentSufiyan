--1. Extract the middle 3 characters from the string 'ABCDEFG'.
--select substring('ABCDEFG',LEN('ABCDEFG')/2,3)
--2. From a table 'Employees' with a column 'FullName', write a query to extract the first name (assuming it's always the first word before a space).
----SELECT LEFT(FullName, CHARINDEX(' ', FullName) - 1) AS FirstName FROM Employees;
--3. Extract the first 5 characters from the string 'SQL Server 2022'.
--select LEFT('SQL Server 2022',3)
--4. From a 'Products' table with a 'ProductCode' column, write a query to get the first 3 characters of each product code.
--select LEFT(ProductCode,3) from Product
--6. From an 'Orders' table with an 'OrderID' column (format: ORD-YYYY-NNNN), write a query to extract just the numeric portion at the end.
--select RIGHT(OrderID,4) from Orders
--7. Write a query to find the length of the string 'SQL Server Functions'.
--select LEN('SQL Server Functions')
--8. From a 'Customers' table, find customers whose names are longer than 20 characters.

--select FirstName ,LastName from Customer where LEN(CONCAT_WS(' ',FirstName,LastName))>10 ;
--9. Compare the results of character count and byte count for the string 'SQL Server' with a trailing space.
--select FirstName,Len('SQ1L Server') as Length, DATALENGTH('SQL Server') as [bit] from Customer
--10. Write a query to find the byte count of an empty string and explain the result.
--Select DATALENGTH('');
--11. Find the position of 'Server' in the string 'Microsoft SQL Server'.
--select PATINDEX('%server%','Microsoft SQL Server')
--12. From an 'Emails' table, write a query to extract the domain name from email addresses.
--select substring(Email,CHARINDEX('@',Email),len(Email)) from Customer;
--13. Find the position of the first number in the string 'ABC123DEF456'.
--select patindex('%[1-9]%','ABC123DEF456')
--14. Write a query to find all product names from a 'Products' table that contain a number.
--select ProductName from Product where patindex('%[1-9]%',ProductName)>1
--15. Join the strings 'SQL', 'Server', and '2022' with spaces between them.
--select CONCAT(' 'SQL','Server',2022)
--16. From 'Employees' table with 'FirstName' and 'LastName' columns, create a 'FullName' column.
--select FirstName, LastName,CONCAT_WS(' ',FirstName,LastName) as FullName from Customer
--19. Change all occurrences of 'a' to 'e' in the string 'database management'.
--17. Join the array ('SQL', 'Server', '2022') with a hyphen as the separator.
--SELECT CONCAT_WS('-', 'SQL', 'Server', 2022);
--18. From an 'Addresses' table, combine 'Street', 'City', 'State', and 'ZIP' columns into a single address string.
----select CONCAT_WS(',',Street, City, State,ZIP )
--19. Change all occurrences of 'a' to 'e' in the string 'database management'.
----select replace('database management','a','e')
--20. From a 'Products' table, write a query to replace all spaces in product names with underscores.
--select ProductName,REPLACE(ProductName,' ','_') from Product
--21. Create a string of 10 asterisks (*).
--select REPLICATE('*',10)
--22. Write a query to pad all product codes in a 'Products' table to a length of 10 characters with leading zeros.
--SELECT ProductCode,RIGHT(REPLICATE('0', 10) + ProductCode, 10) AS PaddedProductCodeFROM Product;
--23. Insert the string 'New ' at the beginning of 'York City'.
--select stuff('YORK CITY',1,0,' NEW ')
--24. From an 'Emails' table, mask the username part of email addresses, showing only the first and last characters.
--SELECT LEFT(Email,1)+Replicate('*',LEN(SUBSTRING(Email,2,charindex('@',Email)-1))-2)+SUBSTRING(Email,charindex('@',Email)-1,LEN(Email)) as hint from Customer ;
--Convert the string 'sql server' to uppercase.
--select upper('sql server')
--26. Write a query to convert all customer names in a 'Customers' table to uppercase.

--update  [dbo].[Customer]
--set [FirstName]=upper([FirstName]),
-- [LastName] =upper([LastName])
--27. Convert the string 'SQL SERVER' to lowercase.
--select LOWER('SQL SERVER')
-- 28.From a 'Products' table, write a query to convert all product descriptions to lowercase.
--update Products
--set ProductsProducts=lower(ProductsProducts)
--29. Remove trailing spaces from the string 'SQL Server '.



--select RTRIM('SQL Server ')
--30. Write a query to remove trailing spaces from all email addresses in an 'Employees' table.



--SElect RTRIM(Email) from Employee
--32. From a 'Comments' table, write a query to remove leading spaces from all comment texts.
--Select LTRIM(CommentText) From Comments
--31. Remove leading spaces from the string '   SQL Server'.
--select LTRIM(' SQL SERVER')

--33. Display the current date in the format 'dd-MM-yyyy'.



--Select FORMAT(CreatedDate,'dd-MM-yyyy') from Product
--34. From an 'Orders' table with an 'OrderTotal' column, display the total as a currency with 2 decimal places.



--select format(sum(Amount),'C2') as OrderTotal from Orders;
--35. Separate the string 'apple,banana,cherry' into individual fruits.



--SELECT value AS Fruit FROM STRING_SPLIT('apple,banana,cherry', ',');
--36. From a 'Skills' table with a 'SkillList' column containing comma-separated skills, write a query to create a row for each individual skill.
--select *  from skills cross apply STRING_SPLIT([SkillList],',')
--37. Write a query to display the current date and time.



--select SYSDATETIME ()
--38. From an 'Orders' table, find all orders placed in the last 24 hours.



--select OrderID from Orders where OrderDate>=DATEADD(HOUR,-24,GETDATE())
--39. Display the current UTC date and time.



--select SYSUTCDATETIME()
--40. Write a query to show the time difference between local time and UTC time.



--select  DATEDIFF(minute,SYSUTCDATETIME(),SYSDATETIMEOFFSET()) as timediff
--41. Convert the current date and time to 'Pacific Standard Time'.


--select TODATETIMEOFFSET (SYSDATETIME(),'-08:00')
--42. From a 'Flights' table with a 'DepartureTime' column in UTC, convert all departure times to 'Eastern Standard Time'.



--select FlightNumber,TODATETIMEOFFSET(DepartureTime,'-05:00') from Flights
--43. Add 3 months to the current date.



--select DATEADD(month,3,SYSDATETIME())
--44. From an 'Employees' table, write a query to calculate each employee's retirement date (65 years from their 'DateOfBirth').



--select DATEADD(YEAR,65,DATEOFBIRTH) from Employees
--45. Calculate the number of days between '2023-01-01' and '2023-12-31'.


--select DATEDIFF(DAY,'2023-01-01','2023-12-31')
--46.From an 'Orders' table, find the average number of days between order date and ship date.
--SELECT AVG(DATEDIFF(DAY, OrderDate, ShippedDate)) AS AvgShippingDays FROM  Orders;
--47. Extract the month number from the date '2023-09-15'.
--select MONTH('2023-09-15')

--49. Extract the year from the current date.


--select year(SYSDATETIME())
--50. From an 'Employees' table, find all employees hired in the year 2022.

--select EmployeesName from Employees where YEAR(HiredDate)='2022'
--51. Check if '2023-02-30' is a valid date.



--select ISDATE('2023-02-30')
--52. Write a query to find all rows in a 'UserInputs' table where the 'EnteredDate' column contains invalid dates.



--select * from UserInputs where ISDATE(EnteredDate)=0
--53. Find the last day of the current month.
--select EOMONTH( GETDATE())
--54. From a 'Subscriptions' table, write a query to extend all subscription end dates to the end of their respective months.



--select Username,EndDate, EOMONTH(EndDate) as newdate from Subscriptions
--55. Display the current date and time.



--SELECT SYSDATETIME()
--56. Compare the results of two different methods to get the current timestamp - are they always the same?



--SELECT 
--    GETDATE() AS OldMethod,
--    SYSDATETIME() AS NewMethod
--57. Get the current date and time with higher precision than standard methods.



--SELECT SYSDATETIME()
--58. Write a query to insert the current high-precision timestamp into a 'Logs' table.



--insert into LOGS values(SYSDATETIME() );
--Remember that you also had a CREATE TABLE query in your list: CREATE TABLE lOGS (logId int primary key identity(1,1),logsdata DATETIME);

--59. Display the current UTC date and time with high precision.



--select SYSUTCDATETIME()
--60. Calculate the difference in microseconds between the current local time and UTC time.



--SELECT DATEDIFF(MICROSECOND, SYSUTCDATETIME(), SYSDATETIME())
--61. Get the current date, time, and time zone offset.



--SELECT SYSDATETIMEOFFSET() AS ServerTimeWithOffset;
--62. From a 'GlobalEvents' table, convert all event times to include time zone offset information.



--SELECT EventName,EventTime,TODATETIMEOFFSET(EventTime, '+00:00') AS EventTime_WithOffset     FROM GlobalEvents;
--63. Extract the month number from the date '2023-12-25'.



--select month('2023-12-25')
--64. From a 'Sales' table, find the total sales for each month of the previous year.


--SELECT  DATENAME(month, SalesDate) AS MonthName,SUM(SalesAmount) AS TotalSales FROM Sales WHERE     YEAR(SalesDate) = YEAR(GETDATE()) - 1    GROUP BY     MONTH(SalesDate),    DATENAME(month, SalesDate)
--65. Extract the day of the month from '2023-03-15'.
--select datename(day,'2023-12-25')
--66. Write a query to find all orders from an 'Orders' table that were placed on the 15th day of any month.
--select OrderID,ProductName,OrderDate from Order where datename(day, OrderDate)=15
--67. Get the name of the month for the date '2023-09-01'.
--select datename(month,'2023-09-01')
--68. From an 'Events' table, write a query to display the day of the week (in words) for each event date.
--select EventsDate,DATENAME(weekday,EventsDate)as names from Events
--69. Create a date for Christmas Day 2023.
--SELECT DATEFROMPARTS(2023, 12, 25) AS ChristmasDay;
--70. Write a query to convert separate year, month, and day columns from a 'Dates' table into a single DATE column.
--SELECT    RecordID,    EventYear,  EventMonth,    EventDay,   DATEFROMPARTS(EventYear, EventMonth, EventDay) AS CombinedDate FROM  Dates;