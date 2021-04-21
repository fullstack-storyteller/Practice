select * from myEmployee
select * from MyDepartment
execute sp_helptext [vw_EmployeesByDepartment]
execute sp_depends tblEmployee

select * from [vw_EmployeesByDepartment]
select * from MyDepartment
/*This view can be seleted from, deleted but when we insert or update or delete, it will cause issue*/

insert into [vw_EmployeesByDepartment] values('Test', GETDATE(), 'Female', 'Mathematics' )
--View or function 'vw_EmployeesByDepartment' is not updatable because the modification affects multiple base tables.

update [vw_EmployeesByDepartment] set Name  = 'Test', dob = GETDATE(), Gender = 'Male', departmentName='Chemistry' where Name='My love Archana'
--View or function 'vw_EmployeesByDepartment' is not updatable because the modification affects multiple base tables.

delete from vw_EmployeesByDepartment where name = 'My Love Archana'
--View or function 'vw_EmployeesByDepartment' is not updatable because the modification affects multiple base tables.

/*
we can write a 'instead of' trigger on vw_EmployeesByDepartment to perform the insert, update or delete operation
*/

--alter trigger tr_vw_EmployeesByDepartment_insteadOf_forInsert
--on vw_EmployeesByDepartment 
--instead of insert
--as
--begin
--	declare @deptID int
--	select @deptID=d.departmentID from inserted i inner join MyDepartment d on i.departmentName=d.departmentName
	
--	if @deptID is null 
--	begin
--		raiserror('Invalid department Name. Statement terminated', 16, 1)
--		return
--	end

--	insert into myEmployee(name,  dob, Gender, DepartmentID ) 
--	select name, dob, Gender, @deptID from inserted
	
--end