select * from tblEmployee
select * from department

select e.Name, e.Gender, e.Salary, d.department_name, d.department_location
from tblEmployee e 
inner join department d on e.department_id= d.department_id
/*
inner join will return only the common columns -> 8 records
*/
select e.Name, e.Gender, e.Salary, d.department_name, d.department_location
from tblEmployee e 
left join department d on e.department_id= d.department_id
/*
	get common columns and the remainig columns from the left hand side table
*/
select e.Name, e.Gender, e.Salary, d.department_name, d.department_location
from tblEmployee e 
right join department d on e.department_id= d.department_id
/*
	get common columns and the remainig columns from the right hand side table
*/

select e.Name, e.Gender, e.Salary, d.department_name, d.department_location
from tblEmployee e 
full outer join department d on e.department_id= d.department_id

/*
get all common rows and non matching records from both tables
*/
select e.Name, e.Gender, e.Salary, d.department_name, d.department_location
from tblEmployee e 
cross join department d -- on e.department_id= d.department_id
/*
Remember a cross join will not have an on clause
because cross join produces a cartesian product of the two tables involved.
*/

--some advanced joins question or concepts
select e.Name, e.Gender, e.Salary, d.department_name, d.department_location
from tblEmployee e 
left join department d on e.department_id= d.department_id
where d.department_id is null
/*
this query returns only the non matching rows from the left table
*/
select e.Name, e.Gender, e.Salary, d.department_name, d.department_location
from tblEmployee e 
right join department d on e.department_id= d.department_id
where e.department_id is null
/*
this query returns only the non matching rows from the right table
*/

select isnull(e.Name,''), e.Gender, e.Salary, d.department_name, d.department_location
from tblEmployee e 
full join department d on e.department_id= d.department_id
where e.department_id is null 
/*
this query returns only the non matching rows from both the table
Never use '=' operator in sql for comparing null character, use 'is' instead
*/












--update tblEmployee set department_id = 100 where ID =1
--update tblEmployee set department_id = 101 where ID =2
--update tblEmployee set department_id = null where ID =3
--update tblEmployee set department_id = null where ID =4
--update tblEmployee set department_id = 102 where ID =5
--update tblEmployee set department_id = 100 where ID =6
--update tblEmployee set department_id = 101 where ID =7
--update tblEmployee set department_id = 100 where ID =8
--update tblEmployee set department_id = 101 where ID =9
--update tblEmployee set department_id = 102 where ID =10
--update tblEmployee set department_id = 100 where ID =10
--insert into department values('IT', 'London', 'Rick')
--insert into department values('HR', 'New york', 'Ron')
--insert into department values('other', 'Sydney', 'Cynderalla')
--insert into department values('Payroll', 'Delhi', 'Chestie')	
--create table department(
--department_id int primary key identity(100, 1),
--department_name varchar(50),
--department_location varchar(50),
--department_head varchar(50)

--)