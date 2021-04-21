/*
In SQL, we have 3 types of user defined functions:
1. Scalar functions
2. Inline table valued function
3. Multi-statement table valued function

Saclar function may or may not have parameters, but always return a single (scalar) value.
The returned value can be of any datatype, except text, ntext, image, cursor and timestamp

*/
--Example:
--system scalar functions
select square(123.4) 'square(123.4)'
select getdate() 'getdate()'

/*
user defined functions
>upto 1024 parameters can be supplied to a sql function
*/



--create function fnAgeInYears(@dob datetime)
--returns int
--as
--begin
--return datediff(year, @dob, getdate()) - 
--(
--	case 
--		when (month(@dob)>month(getdate())) 
--				or (month(@dob)=month(getdate()) 
--						and day(@dob)>day(getdate()))
--		then 1 
--		else 0 
--	end
--)
--end


select dbo.fnAgeInYears('1994-06-01') as Age
select dbo.fnAgeInYears('1992-12-01') as Age

select Name, dob, dbo.fnAgeInYears(dob) Age from tblEmpDob where dbo.fnAgeInYears(dob)> 25

/*we can convert this function to a stored procedure*/
--create procedure spAgeInYears
--@dob datetime
--as
--begin
--select datediff(year, @dob, getdate()) - 
--(
--	case 
--		when (month(@dob)>month(getdate())) 
--				or (month(@dob)=month(getdate()) 
--						and day(@dob)>day(getdate()))
--		then 1 
--		else 0 
--	end
--)
--end

execute spAgeInYears '1994-06-01'
/*
Function can be used in where clause, 
but a stored procedure can't be used in where clause.
*/

/*-----------------------------------------Inline table valued functions--------------------------------------------------------------*/
--Inline table valued functions return a table
--create table MyDepartment(
--departmentID int primary key identity(1, 1),
--departmentName varchar(50)
--)
--drop table MyDepartment

--alter table MyDepartment
--add constraint pk_MyDepartment_ID primary key(depeartmentID)
--insert into MyDepartment values( 'Physics')
--insert into MyDepartment values( 'Chemistry')
--insert into MyDepartment values( 'Mathematics')

--create table myEmployee(
--ID  int identity(1, 1) primary key,
--Name varchar(50),
--dob datetime,
--Gender varchar(6),
--DepartmentID int foreign key references MyDepartment(departmentID)
--)

--insert into myEmployee values('Archana', '01-06-1994', 'Male', 1)
--insert into myEmployee values('Manish', '01-08-1992', 'Male', 1)
--insert into myEmployee values('Archana1', '01-09-1992', 'Male', 1)
--insert into myEmployee values('Manish2', '01-06-1996', 'Male', 1)

--update myEmployee set DepartmentID =2 where ID =2
--update myEmployee set gender = 'Female' where ID =4
--update myEmployee set DepartmentID =3 where ID =4

/*

create function fnGetEmployeesByGender (@Gender varchar(6))
returns Table
as 
--begin --it is a compilation error to have begin and end statements for inline table valued function
return (select Name , dob, Gender, DepartmentID from myEmployee where Gender =@Gender)
--end

*/
select * from  dbo.fnGetEmployeesByGender('Male')
select * from  dbo.fnGetEmployeesByGender('Female') where Name ='Manish2'

/*this is how we invoke a table valued function.
i.e. we invoke it like a table.*/

--1. Inline tbales can be used to achieve the functionality of parameterized views
--2. The table returned by the table valued function can also be used to join with other tables. See below

select		E.Name, E.Gender, d.departmentName 
from		dbo.fnGetEmployeesByGender('Female') E 
inner join	MyDepartment D on e.DepartmentID = d.departmentID



/*-----------------------------------------Multi-statement tablevalued function--------------------------------------------------------------*/
--inline table valued function for getting all the employees
/*
create function fn_Inline_GetEmployees()
returns table
as return (select ID, Name, Cast(dob as date) 'DOB' from myEmployee)
*/


--Multi-satement table valued function

/*

create function fn_mstvf_getEmployees()
returns @table table (ID int, theName varchar(50), myDob date)--this is the structure of the table being returned.
as
begin --we can have begin and end block in multi statement table valued function
	Insert into @table
	select id, Name, cast(dob as date) from myEmployee
	return --shows that return is happenning
end

*/
select * from dbo.fn_Inline_GetEmployees()

select		E.Name, E.DOB, d.departmentName 
from		dbo.fn_Inline_GetEmployees() E 
inner join	MyDepartment D on e.ID = d.departmentID
/*Inline table valued functions in join statements*/

select * from dbo.fn_mstvf_getEmployees()

select		E.theName, E.myDob, d.departmentName 
from		dbo.fn_mstvf_getEmployees() E 
inner join	MyDepartment D on e.ID = d.departmentID
/*Multi-statement table valued functions in join statements*/

/*
Differences between Inline table value functions and the multistatement table valued functions
*/

--1.
/*
In an Inline table valued function, the returns clause can't contain the structure of the table, the function returns. where as,
with the multi-statement table valued function, we specify the structure of the table that gets returned.
*/

--2.
/*
Inline table valued function cannot have begin and end block, where as the multistatement table valued function, always have an begin and end statement.
*/

--3.
/*
Inline table valued functions are better in performance, than multi-statement table valued function.
If a task can be done by inlin table valued function we should always prefer using that over its counterpart

Reason:
Internally SQL server treats an Inline table valued function much like it would a view and treats a multi-statement valued function similar to 
how it would a stored procedure.
*/

--4.
/*
Its's possible to update the underlying table, using the an inline table valued function, 
but not possible using the multi-statement table valued function
See below.
*/
select * from dbo.fn_Inline_GetEmployees()

update dbo.fn_Inline_GetEmployees() set Name ='My love Archana' where ID=3
select *  from myEmployee

/*---------------------------------------------------------------------------------------------------------------------------------------------*/
/*--------------------------------------------------Important concepts regarding Functions in SQL----------------------------------------------*/
/*---------------------------------------------------------------------------------------------------------------------------------------------*/

/*
Deterministic Function:
A deterministic function will always return the same result anytime they are called with a specific set of Input values, and
given the same state of state of the database.
example: power(), count(), square(), sum(), avg()
Note: all aggregate functions are deterministic function
*/

/*
Non Deterministic functions:
They may return different values for the same set of input values and given the same state of state of the database.

example: getdate(), rand(), currenttimestamp()
Note: Rand() function can be deterministic when we supply the seed value like 
rand(2)<- this is deterministic, as seed value is supplied.
rand()<- non deterministic
*/


/*Let's discuss about encrypting the function definition*/


--create function fn_getNameByID(@id int)
--returns varchar(50)
--as 
--begin
--	declare @result varchar(50)
--	select @result = Name from tblEmpDob where ID = @id
--	return @result
--end

select dbo.fn_getNameByID(2)
sp_helptext fn_getNameByID --this will show the test if the function is not encrypted
sp_depends fn_getNameByID

create function fn_getNameByID_with_encrypt(@id int)
returns varchar(50)
with encryption
as 
begin
	declare @result varchar(50)
	select @result = Name from tblEmpDob where ID = @id
	return @result
end


sp_helptext fn_getNameByID_with_encrypt--The text for object 'fn_getNameByID_with_encrypt' is encrypted.
select dbo.fn_getNameByID_with_encrypt(3)





/*Let's discuss about schema binidng the function*/

--in its current status function fn_getNameByID and tblEmpDob are kind of indenpendent.
--if someone want to delete the table tblEmpDob, then no error will be raised.
--but this will eventually break the function fn_getNameByID

--to make sure this is not happening, we should schema bind the function to the table
--as below


--alter function fn_getNameByID(@id int)
--returns varchar(50)
--with schemabinding --the base object can't be modified or dropped
--as 
--begin
--	declare @result varchar(50)
--	select @result = Name from dbo.tblEmpDob where ID = @id
--	return @result
--end

--drop table tblEmpDob --check the below error.
--Cannot DROP TABLE 'tblEmpDob' because it is being referenced by object 'fn_getNameByID'.

--not only deleteing any kind of change to the table will not be allowed
 