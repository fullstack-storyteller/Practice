select * from tblEmployee

--creating a stored parameter with output parameter
--create procedure spGetEmployeeCountByGender
--@Gender varchar(20),
--@EmployeeCount int output 
--as
--begin
--	select @EmployeeCount = count(id) 
--	from tblEmployee
--	where Gender=@Gender
--end

--How to invoke a stored procedure with an output parameters
declare @emp_Count int --this will hold the value of output parameter
execute spGetEmployeeCountByGender 'Male', @emp_Count output --output keyword must be supplied, otherwise it will be null.
print @emp_Count

--using the output parameter
execute spGetEmployeeCountByGender @EmployeeCount= @emp_Count output, @Gender='Female' --output keyword must be supplied, otherwise it will be null.
print @emp_Count


sp_help spGetEmployeeCountByGender --give information about stored procedure, 
--this sp_help can be used with any database object, stored procedure, table, view or triggers
--you can also use the key combination Alt+F1 for getting the same information.

sp_depends spGetEmployeeCountByGender --gives dependencies of the procedure
sp_depends tblEmployee --gives stored procedures depending upon this table.
