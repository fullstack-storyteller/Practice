/*

Indexes are used by the sql queries to find the data quickly in the tables.
indexes are created in tables and views.

the existence of the right index greatly improves the performance.
In absense of an index, the query engine will have to cheeck each and every rows in the table from beginning to end.
This is called table scan, which is bad.

*/

--create table TestTableEmployee(
--empid int identity(1, 1) primary key,
--emp_name varchar(50), 
--salary int,
--gender varchar(6)
--)

--declare @counter int 
--set @counter =1
--declare @name varchar(30)
--set @name = 'Employee - '

--while @counter <=2000000
--begin
--	insert into TestTableEmployee values(
--	@name+cast(@counter as varchar), 
--	floor(rand()*10000) ,
--	case
--		when floor(rand()*10) >5 
--			then 'Male'
--		else 'Female'
--	end
--	)
--	set @counter = @counter+1
--end

select * from TestTableEmployee
truncate table testtableemployee
--before index
select * from TestTableEmployee where gender ='Female' --13 seconds
select * from TestTableEmployee where salary >= 5000 --11 seconds

create index ix_TestTableEmployee_salary
on TestTableEmployee(salary asc)

create index ix_TestTableEmployee_gender
on TestTableEmployee(gender asc)
--this will create a non unique, non clustered index

--after index
select * from TestTableEmployee where gender ='Female' --10 seconds
select * from TestTableEmployee where salary >= 5000 --9 seconds

/*Find indexes on a table*/
execute sp_helpindex TestTableEmployee

--how to drop a index, make sure to use table_name.index_name format.
drop index TestTableEmployee.ix_TestTableEmployee_salary
drop index TestTableEmployee.ix_TestTableEmployee_gender


----------------------------------------------------------------------------------------------------
/*
Following types of indexes are available in sql:
1. CLustered
2. Non Clustered
3. Unique
4. Filtered
5. XML
6. Full Text
7. Spatial
8. Columnstore
9. Index with included columns
10. index on computed columns
*/

/*---clustered index
A primary key constraint will automatically create a unique and clustered index on the table.
Note: A clustered index determines the physical order of data in a table. For this reason, a table can have
only one clustered index.

For example,
if in a table you ahve a primary key (which is a clustered index btw), then no matter what is the
order of inserts performed in the table, we extract by using select statement,
the result will always be order with respect to the primary key of the table.

A clustered index is analogous to a telephone directory, where the data is arranged by the last name.
We just learnt that, a table can only have one clustered index. However, the index can contain multiple 
columns( a composite index), like a telephone directory is organised by the last name and the first name.
*/

select * from tblEmployee --has a clustered index or primary key
execute sP_helpindex tblEmployee

--drop index tblEmployee.
--Cannot drop the index 'tblEmployee.PK__tblEmplo__3214EC27F4F01879', because it does not exist or you do not have permission.

--since the above error is occuring, we need to delete the index graphically from the object explorer

/*
let's create a clustered  on gender and salary
*/

create clustered index ix_tblEmployee_gender_salar
on tblEmployee(gender desc, salary asc)
--drop index tblEmployee.ix_tblEmployee_gender_salar

select * from tblEmployee

/*--Non Clustered index
A nonclustered index is analogous to an index in a text book.
The data is stored in one place, the index in another place. The index will have pointers to the storage location of the data.

Since the nonclustered index is stored separately from the actual data, a table can have more than one
non clustered index, just like how a book can have an index by chapters at the beginning and another
index by common terms at the end.

In the index itself, the data is stored in an ascending or descending order of the index key, which doesn't 
in anyway influence the storage of data in the table
*/

create nonclustered index ix_tblEmployee_name
on tblEmployee(name)

/*Differences between clustered index and the non clustered indexes*/

--1.
/*
There can be only one clustered index, and there can be multiple non clustered index

*/

--2.
/*
CLustered indexes are slightly faster than the non clustered indexes, becasue the nonclustered
index has to refer back to the table, if the selected column is not present in the index
*/

--3.
/*
Clustered index determines the storage order of rows in the table, and hence doesn;t reuiqre additional 
disk space, but where as a non clustered index is stored separately from the table, additioanl storage
space is required.
*/

-----------------------------------------------------------------------------------------------------------------
/*
Unique and Nonunique index
*/

/*
Unique index is used to enforce uniqueness of key value in the index

By default primary key constraint creates a unique clustere index.
Note:
Uniqueness is a property of ann Index, and both clustered and non-clustered indexes can be unique.
*/

create unique nonclustered index uix_tblEmplpoyee_name_gender
on tblEmployee(name, gender)

execute sp_helpindex tblemployee

/*
Difference between unique Constraint and unique index
There are no major difference between a unique constraint and a unique index.
In fact, when you add a unique constraint, a unique idex gets created behin dthe scene.
*/

Alter table tblEmployee
add constraint tblEmployee_city unique (city)

--duplicates are there, but iof the above query runs fine both a unique index and unique constraint are created simultaneously.

/*--Note:
 1. By default, a primary key constraint creates a uniqueclustered index, where as a unique contraint
 creates a unique non clustered index.

 2. A unique constraints or a unique index cannot be created on an existing table, if the table contains 
 duplicate values in the key columns. like the one example above

*/



/***************************************************************************************************************/

/*Advantages of indexes: Indexes help queries to find data quickly*/

--select statements with a where clause will benefit from the right index
--delete and update statements will also beneift
--order by statements will also benefit
--group by statements will also benefit

/*Disadvantages of Indexes: */
--Additional disk space for non clustered space
--Insert and update statement can be come slow:
		--However, locating a data is made faster with the help of index, any data update will cause all the stored indexes to be updated.
		--so avoid a high number of index, it is bad for performance


/*
Covering Query:
If all the index that you have requested in the select clause of the query, 
are present in the index, then there is no need to lookup in the table at all.
The requested column / result can be read directly from the index itself.

A cluster index always cover a query, as all the columns are present in the actual table itself. 
*/