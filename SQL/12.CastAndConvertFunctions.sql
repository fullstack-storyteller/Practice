/*
To Convert one datatype to another , cast and convert functions can be used.
cast(expression as datatype[(length)])
Convert(datatype[(length)], expression [, style])
*/

--create table tblEmpDob1(
--ID int primary key identity(1, 1),
--Name varchar(50),
--dob datetime
--)

select * from tblEmpDob1

--insert  into tblEmpDob1 values('Archana', '03/31/1999')
--insert  into tblEmpDob1 values('Manish', '01/31/1994')
--insert  into tblEmpDob1 values('Ramesh', '01/31/2001')
--insert  into tblEmpDob1 values('Surbhi', '07/30/1974')
--insert  into tblEmpDob1 values('Mylo', '09/23/1980')
--insert  into tblEmpDob1 values('Poonam', '11/30/1996')
--insert  into tblEmpDob1 values('Sonu', '12/21/1994')

select id, [Name], dob, cast(dob as date) 'Using Cast', convert(date, dob, 111) 'Using Convert' from tblEmpDob1
--using date datetype with convert will not any effect its style parameter.
--so if you want to use the style then you must use varhcar instead of date, see the next example.

select id, [Name], dob, cast(dob as date) 'Using Cast', convert(varchar, dob, 111) 'Using Convert' from tblEmpDob1

select name + cast(id as varchar) [ID+Name],* from tblEmpDob1

--alter table tblEmpDob1
--add registrationDate datetime

select * from tblEmpDob1

--update tblEmpDob1 set registrationDate = '1999-03-31 12:22:30.000' where ID =1
--update tblEmpDob1 set registrationDate = '1999-03-31 14:22:30.000' where ID =2
--update tblEmpDob1 set registrationDate = '1999-03-31 10:12:00.000' where ID =3
--update tblEmpDob1 set registrationDate = '2019-01-31 09:22:30.000' where ID =4
--update tblEmpDob1 set registrationDate = '2019-01-31 13:22:30.000' where ID =5
--update tblEmpDob1 set registrationDate = '2001-03-24 12:22:30.000' where ID =6
--update tblEmpDob1 set registrationDate = '2001-03-24 12:22:30.000' where ID =7
--update tblEmpDob1 set registrationDate = '2001-03-24 11:09:30.000' where ID =8


select registrationDate [Registration Date], count(1) 'CounterColumn' 
from tblEmpDob1
group by registrationDate 
order by CounterColumn desc

select cast(registrationDate as date) [Registration Date], count(1) 'CounterColumn' 
from tblEmpDob1
group by cast(registrationDate as date)
order by CounterColumn desc

--without casting the datetime column registrationdate it will result in unique columns

/*
1.
Cast is based on ANSI standard and Convert is specific to SQL Server.
So, if portability is a concern and if you want to use the script with other database application, use cast()

2.
Convert provides more flexibility than Cast using the style parameter.
=> the general rule is use cast(), unless you want to use the style parameter fromo convert fucntion.
*/