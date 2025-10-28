Question 1: Find the total number of customers in each country.
--select count(CustomerName),Country from Customers
--group by Country 
Question 2: Calculate the average unit price of products in each category.
--select avg(UnitPrice) as avgprice,Category from [dbo].[Products]
--group by [Category]
Find the maximum and minimum salary in each department.
--select max([Salary]) as maxsalry,min([Salary]) as minsalary ,[Department] from [dbo].[Employees]
--group by [Department];
Question 4: Count the total number of products supplied by each supplier.
--Select count(ProductID) ,Supplier from Products
--group by Supplier
Question 5: Calculate the total value of inventory (UnitsInStock × UnitPrice) for each product category.
--select sum(UnitsInStock*UnitPrice) as TotalValue,Category from [dbo].[Products] group by Category
Question 6: Find all product categories that have more than 2 products.
--select Category,count(ProductID)  as countofproduct from Products group by Category having count(ProductID)>2
Question 7: List departments where the average salary is greater than $60,000.
--select avg(Salary),Department from Employees group by Department having avg(Salary)>60000
Question 8: Show product categories where the average unit price is between $100 and $500
--select [Category],avg([UnitPrice]) from [dbo].[Products]
--group by [Category] having avg([UnitPrice]) between 100 and 500
Question 9: Find suppliers who supply products worth more than $10,000 in total inventory value.
--select [Supplier], sum([UnitPrice]*[UnitsInStock]) as totalinventoryvalue from [dbo].[Products] 
--group by [Supplier] having sum([UnitPrice]*[UnitsInStock]) >10000
Question 10: List countries that have more than 1 customer and show the customer count.
--select count([CustomerID]),[Country] from [dbo].[Customers] 
--group by [Country] having count([CustomerID])>1