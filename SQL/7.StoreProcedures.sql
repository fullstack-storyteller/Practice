/*
A stored procedure is a group of transact - sql statement.
if we have a situation where we write a query over and over again, you can save that specific query as
a stored procedure, and call it just by name.
*/

--create proc 
--or
--create procedure spGetEmployees
--as 
--begin
--select * from tblEmployee
--end

exec spGetEmployees
--or
execute spGetEmployees

--create proc spGetEmployeesByGenderAndDept 
--@gender varchar(20), 
--@departmentid int
--as 
--begin
--select * from tblEmployee where Gender=@gender and department_id= @departmentid

--end

exec spGetEmployeesByGenderAndDept 'Male', 102

--note:
/*
if we pass the parameters using the name of the parameter then the order of passing the parameters doesn't matter.
Refer Example below:

*/
exec spGetEmployeesByGenderAndDept @gender='Male', @departmentid=101 --this is correct
exec spGetEmployeesByGenderAndDept @departmentid=101, @gender='Male' --this is also correct

--get definition of stored procedures
--sp_helptext spGetEmployeesByGenderAndDept

--use 'Alter' keyword instead od create to alter definition of a procedure
--use drop procedure 'sp_name' to delete the stored procedure.


/*
Encrypt a stored procedure as below, i.e. use the 'with encryption' switch
*/

create proc spGetEmployeesByGenderAndDeptEncrypted 
@gender varchar(20), 
@departmentid int
with encryption
as 
begin
select * from tblEmployee where Gender=@gender and department_id= @departmentid
end

/*
Notes:
-> once encrypted, the sp_helptext or create to script command from object explorer will not work.
-> the encrypted stored procedures can only be deleted.
*/

sp_helptext spGetEmployeesByGenderAndDeptEncrypted --gives the following result: "The text for object 'spGetEmployeesByGenderAndDeptEncrypted' is encrypted."