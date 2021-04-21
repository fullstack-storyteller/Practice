select * from tblEmployee

/*
Whenever a stored procedure executes, it returns a integer status variable.
usually Zero indicates success,
and non-zero indicates failure
*/

--sp_depends tblEmployee

--create procedure spGetEmployeeByID @id int 
--as begin

--select * from tblEmployee where ID =@id
--end

declare @return_value int
execute @return_value=spGetEmployeeByID @id=1

print @return_value --return 0


/*
example of output keyword
*/
--create procedure getTotalCount 
--@TotalCount int output
--as
--begin
--select @TotalCount = count(id) from tblEmployee
--end
declare @Total int 
execute getTotalCount @Total output
select @Total

/*
Doing the above example using the return
*/
--create procedure getTotalCountUsingReturn
--as
--begin
--return (select count(id) from tblEmployee)
--end

declare @TotalUsingReturn int
execute @TotalUsingReturn = getTotalCountUsingReturn
select @TotalUsingReturn

--Note: A stored procedure can only return a integer using the 'return' keyword.
--so, if you need to return a string / varchar, you must use an 'output' keyword
--Use return only when you have to return an integer

--Note: A stored procedure and return only one value not multiple values, hence if we have such requireement, use output
--Note: A stored procedure return is only used to convey the success or failure of an stored procedure
--success->0
--failure->non-zero