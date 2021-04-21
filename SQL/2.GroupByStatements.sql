
--insert into tblEmployee values ('Tom', 'Male', 4000, 'London')
--insert into tblEmployee values ('Pam', 'Female', 3000, 'New York')
--insert into tblEmployee values ('John', 'Male', 3500, 'London')
--insert into tblEmployee values ('Sam', 'Male', 4500, 'London')
--insert into tblEmployee values ('Todd', 'Male', 2800, 'Sydney')
--insert into tblEmployee values ('Ben', 'Male', 4000, 'London')
--insert into tblEmployee values ('Sara', 'Female', 4800, 'London')
--insert into tblEmployee values ('Valerie', 'Female', 5500, 'London')
--insert into tblEmployee values ('James', 'Male', 6500, 'London')
--insert into tblEmployee values ('Russel', 'Male', 8800, 'London')


--create table tblEmployee(
--ID int identity(1, 1) primary key,
--Name varchar(50),
--Gender varchar(6),
--Salary float,
--City varchar(10)
--)
select * from tblEmployee

Select sum(salary) from tblEmployee
/*
SQL was not recognizing the newly created tables so, I pressed ctrl+shift+r to refresh the intellisense.
*/

--grouping based on City
Select city, sum(salary) as TotalSalary from tblEmployee group by City order by TotalSalary desc

--grouping based on City and Gender
Select city, gender, sum(salary) as TotalSalary from tblEmployee group by City, Gender order by TotalSalary desc

--grouping and counting the number of employee by city and gender
Select city, gender, sum(salary) as TotalSalary, COUNT(1) as TotalEmployees, max(salary) as MaxSalary, min(Salary) as MinSalary
from tblEmployee group by City, Gender order by TotalSalary desc
Select * from tblEmployee


Select city, max(salary) as MaxSalary from tblEmployee group by City order by MaxSalary desc
Select city, min(salary) as MinSalary from tblEmployee group by City order by MinSalary desc

--grouping and counting the number of employee by city and gender and only displaying the records of london
--we can do this two ways
--using the where clause , remember in this case the filter or the where clause will come before the group statement
Select city, gender, sum(salary) as TotalSalary, COUNT(1) as TotalEmployees, max(salary) as MaxSalary, min(Salary) as MinSalary
from tblEmployee 
where City = 'London'
group by City, Gender order by TotalSalary desc
Select * from tblEmployee

--using the having clause , remember in this case the filter or the having clause will come after the group statement but before order by
Select city, gender, sum(salary) as TotalSalary, COUNT(1) as TotalEmployees, max(salary) as MaxSalary, min(Salary) as MinSalary
from tblEmployee 
group by City, Gender 
having City = 'London'
order by TotalSalary desc
Select * from tblEmployee
/*
Difference in the above two approach is:
1.
the where condition filter the rows based on its criteria first and only after that the aggregation(grouping) is applied. Thus it is more performant
the having clause performs the aggregation (grouping) on the entire result set. Hence, we can think of using it only when necessary.

2.
Having clausecan only be used with Select statements
where as where clause can be use in select , insert, update, delete.

3. aggregate function like sum, max min, avg, can not be used in where clause. in such scenarios, we need having clause.
check out the below program
*/

--Select city, gender, sum(salary) as TotalSalary, COUNT(1) as TotalEmployees, max(salary) as MaxSalary, min(Salary) as MinSalary
--from tblEmployee 
--where sum(salary)> 3000 --this is incorrect because we can't use the aggreate function in where clause
--group by City, Gender 
--order by TotalSalary desc
--Select * from tblEmployee

Select city, gender, sum(salary) as TotalSalary, COUNT(1) as TotalEmployees, max(salary) as MaxSalary, min(Salary) as MinSalary
from tblEmployee 
group by City, Gender 
having City = 'London' and sum(salary) > 11000 --this is perfectly valid, as aggregate functions can be used by having clause.
order by TotalSalary desc
Select * from tblEmployee






