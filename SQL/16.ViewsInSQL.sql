/*
What is a View?
A view is nothing more than a saved sql select query.
A view can also be consisdered as a virtual table
*/

/*

CREATE TABLE [dbo].[myEmployee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[dob] [datetime] NULL,
	[Gender] [varchar](6) NULL,
	[DepartmentID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[myEmployee]  WITH CHECK ADD FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[MyDepartment] ([departmentID])
GO


CREATE TABLE [dbo].[MyDepartment](
	[departmentID] [int] IDENTITY(1,1) NOT NULL,
	[departmentName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[departmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


*/

select * from myEmployee
select * from MyDepartment

select 
e.Name, 
e.dob,
e.Gender,
d.departmentName
from myEmployee e
inner join MyDepartment d on e.DepartmentID =d.departmentID

--create view vw_EmployeesByDepartment
--as
----no begin or end statements are needed
--select 
--e.Name, 
--e.dob,
--e.Gender,
--d.departmentName
--from myEmployee e
--inner join MyDepartment d on e.DepartmentID =d.departmentID

select * from vw_EmployeesByDepartment
select * from vw_EmployeesByDepartment where departmentName = 'Chemistry'

execute sp_helptext vw_EmployeesByDepartment

/*
Advantages of View:
1. Views can be used to reduce the complexity of the database schema
2. Views can be used as a mechanism to implement row and column level security
3. Views can be used to present aggregated data and hide detailed data.

*/

--row and column leve security

--alter view vw_EmployeesByDepartment
--as
--select 
--e.Name, 
--e.dob,
--e.Gender,
--d.departmentName
--from myEmployee e
--inner join MyDepartment d on e.DepartmentID =d.departmentID
--where d.departmentName ='Physics'

select * from vw_EmployeesByDepartment

--create view vw_summarize_Data
--as
--select d.departmentName, count(*) 'Employee Count'
--from myEmployee e
--inner join MyDepartment d on e.DepartmentID =d.departmentID
--group by d.departmentName 

select * from vw_summarize_Data

/**********************************************************************************************/
/******************************** Updateable view *********************************************/
/**********************************************************************************************/

select * from myEmployee
execute sp_helpindex myemployee
--alter table myEmployee
--drop constraint DF__myEmploye__salar__0B2410A1

--alter table myEmployee
--drop column salary 

--alter table myEmployee
--add salary int default floor(rand()*10000)

--update myEmployee set salary = floor(rand()*10000)

--create view vw_getEmployeesExceptSalary
--as
--select ID, Name , dob, gender, departmentName
--from myEmployee e inner join MyDepartment d on e.DepartmentID=d.departmentID


select * from vw_getEmployeesExceptSalary --selecting from the view
/*in sql server the views are updateable*/
update vw_getEmployeesExceptSalary set Name = 'Troubled Stars' where ID =3 --updateing in a vieweven when the view has multiple underlying tables.
update vw_getEmployeesExceptSalary set departmentName = 'Geology' where departmentName ='Physics' and Name ='Geology' 
--updateing in a vieweven when the view has multiple underlying tables. but there is problem as the base table myemployees get updated

update vw_getEmployeesExceptSalary set name ='Archana', departmentName = 'Geology' where departmentName ='Physics' and Name ='Geology' --gives error
--View or function 'vw_getEmployeesExceptSalary' is not updatable because the modification affects multiple base tables.



--bottomline is, if during an update or delete using a view if multiple underlying tables are getting updated or deleted, sql server will throw an error




select * from myEmployee --this proves that the underlying base table is updated
select * from MyDepartment


delete  from vw_getEmployeesExceptSalary where departmentName = 'Physics'
delete  from vw_getEmployeesExceptSalary where ID =1
delete  from vw_getEmployeesExceptSalary where Name='Archana'
--View or function 'vw_getEmployeesExceptSalary' is not updatable because the modification affects multiple base tables.

/*the underlying table in a view is only one, then we can perform all the funcitons like insert, delete , select, update*/

select * from TestTableEmployee

--create view vw_employeeSalaryGreaterthan6000
--as
--select empid, emp_name, gender
--from TestTableEmployee where salary > 6000

select * from vw_employeeSalaryGreaterthan6000
update vw_employeeSalaryGreaterthan6000 set emp_name = 'Manish', gender='Male' where empid=2 --works fine

select * from vw_employeeSalaryGreaterthan6000 where empid=2
select * from TestTableEmployee where empid=2

insert into vw_employeeSalaryGreaterthan6000 values('Titanic','Female') --works fine
select * from TestTableEmployee where emp_name ='Titanic'

delete from vw_employeeSalaryGreaterthan6000 where empid=2 --works fine
select * from vw_employeeSalaryGreaterthan6000 where empid=2
select * from TestTableEmployee where empid=2
