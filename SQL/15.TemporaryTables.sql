/*

Temporary Tables are very similar to permanent tables. Permanet Tables get created in the database you specify, and remain in the database permanently, until you delete (drop )
them. On the other hand, temporary tables get created in the tempdb and are automatically deleted, when they are no longer used.

Diferrent Types of temporary table:
1. Local Temporary tables
2. Global temporary tables

*/

/*
Local temporary table 
*/

create table #PersonDetails(id int, Name varchar(50))

insert into #PersonDetails values(1, 'Mike')
insert into #PersonDetails values(2, 'John')
insert into #PersonDetails values(3, 'Todd')

select * from #PersonDetails

/*
To check if the local temporary table is created:
-----------------------------------------------------------------------
Temporary tables are created in the tempdb.
Query the sysobjects system table in tempdb. The name of the table is suffixed 
with a lot of underscores and a random number.
For this reason, you have to use the LIKE operator in the query.

*/

select * from tempdb..sysobjects where name like '%#Persondetails%'

/*
A local temporary table is available, only for the connection that has created the table.

A local temporary table is automatically dropped when the connection that has created it, is closed.

If the user wants to explicitly drop the temporary table, he can do so using  "DROP Table #PersonDetails"

If the temporary table, is created inside the stored procedure, it gets dropped automatically 
upon the completion of stored procedure.
see next example

It is possible for different connection to createa local temporary table with the same name, for example,
User1 and User2 , both can create a local temporary table with the same name #PersonDetails
*/

--alter procedure spcreateTempTable
--as begin
--create table #PersonDetails(id int, name varchar(50))
--insert into #PersonDetails values(1, 'Mike')
--insert into #PersonDetails values(2, 'John')
--insert into #PersonDetails values(3, 'Todd')

--select * from #PersonDetails
--end

execute spcreateTempTable
select * from #PersonDetails

DROP Table #PersonDetails

/*

Global Temporary tables:
Use ## to create a global temporary table.
the global temporary table will be accessible for all the connections where it reffered, but will get dropped
when the last connection referring it has closed.
*/

create table ##EmployeeDetails(id int, name varchar(50))
insert into ##EmployeeDetails values(1, 'Mike')
insert into ##EmployeeDetails values(2, 'John')
insert into ##EmployeeDetails values(3, 'Todd')

select * from ##EmployeeDetails

/*
Differences in global and local temporary tables:

*/

--1.
/*
Local tempr=orary tables are prefixed with # while global temporay tbales are prefixed with ##

SQL server appends some random numbers at the end of the local temp table name, where this is 
not done for global temp table names.

Local temporary tables are only visible to that session of the SQL server, which has created it, where as
global temporary tables are visible to all the SQL server session

Local temporary tables are automatically dropped, when the session that created the tables is closed, where as
global temporary tables are destroyed when the last connection that it referencing the global temp table is closed.
*/
