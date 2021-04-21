alter procedure qs_getAllTeachers  
as  
begin  
 select  T.id 'TeacherID', T.name 'TeacherName', T.qualification 'TeacherQualification', T.gender 'TeacherGender', T.AnnualPackage 'AnnualSalary',T.HourlyPay , T.HoursWorked,  
 D.name 'DepartmentName' , D.id 'DeptID'
 from tblTeacher T inner join   
 tblDepartment D on T.department = D.id  
  
end

sp_helptext qs_getAllTeachersByID

--alter table tblTeacher
--add HoursWorked int

--alter table tblTeacher
--add HourlyPay int

--alter table tblTeacher
--add AnnualPackage int
--alter table tblTeacher
--add EmpType int

--Alter Table tblTeacher
--drop constraint DF__tblTeache__salar__43D61337

--Alter Table tblTeacher
--drop column salary

select * from tblTeacher
--update tblTeacher set gender =1 where id<=10
--update tblTeacher set gender =2 where id>10 and id <22
--update tblTeacher set gender =3 where id>=22
--alter table tblteacher
--add gender int 
--alter table tblTeacher
--drop column gender


--create procedure qs_getAllDeptarments
--as begin
--select id 'DEPT_ID', name 'DEPT_NAME' from tblDepartment 
--end

--declare @latestID int 
--exec qi_Teacher  'test me', 101, 'Ph.D.', 34000, 'Male', @latestID out
--select @latestID
--select * from tblTeacher
--alter procedure qi_Teacher
--@t_name varchar(100),
--@deptID int,
--@qual varchar(20),
--@gender int,
--@hoursWorked int =null,
--@hourlyPay int = null,
--@annualSal int=null,
--@type int,
--@latestID int out
--as
--begin
--insert into tblTeacher values(@t_name, @deptID, @qual,@gender, @hoursWorked, @hourlyPay, @annualSal, @type)
--set @latestID =SCOPE_IDENTITY()
--end


sp_helptext qs_getAllTeachers

exec qs_getAllTeachersByID 32
exec qs_getAllTeachersByID 13


alter procedure qs_getAllTeachersByID
@id int
as
begin
	select  T.id 'TeacherID', T.name 'TeacherName', T.qualification 'TeacherQualification', T.gender 'TeacherGender', isnull(T.AnnualPackage,0) 'TeacherSalary',
	isnull(T.HourlyPay, 0) 'HourlyPay',isnull(T.HoursWorked, 0) 'HoursWorked',
	D.id 'DeptID' ,D.name 'DepartmentName', isnull(T.EmpType, -1) 'EmpType'
	from tblTeacher T inner join 
	tblDepartment D on T.department = D.id
	where T.id =@id
end

--update tblTeacher set AnnualPackage = 100000*rand(), EmpType =1 where id<15
--update tblTeacher set HoursWorked = floor(rand() *  10000), HourlyPay=floor(rand()*100), EmpType =2 where id>=15


--create procedure qs_getAllTeachers
--as
--begin
--	select  T.id 'TeacherID', T.name 'TeacherName', T.qualification 'TeacherQualification', T.gender 'TeacherGender', T.salary 'TeacherSalary',
--	D.name 'DepartmentName'
--	from tblTeacher T inner join 
--	tblDepartment D on T.department = D.id

--end