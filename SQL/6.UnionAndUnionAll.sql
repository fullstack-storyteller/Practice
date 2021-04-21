--create table tblIndiaCustomers(
--id int identity(1, 1),
--Name varchar(100),
--Email varchar(100)
--)

--create table tblUKqCustomers(
--id int identity(1, 1),
--Name varchar(100),
--Email varchar(100)
--)

--insert into tblIndiaCustomers values('Raj', 'r@r.com')
--insert into tblIndiaCustomers values('Saj', 's@s.com')

--insert into tblUKqCustomers values('Ben', 'b@b.com')
--insert into tblUKqCustomers values('Seth', 'se@se.com')
--insert into tblIndiaCustomers values('Saj', 's@s.com')


select * from tblIndiaCustomers
union all
select * from tblUKqCustomers


--to get the query execution plan press: ctrl+L after highlighting the query.

--using union all take the all the resultset from the first table
--then it takes the result set from the next table
--then it simply displays it 

select * from tblIndiaCustomers
union
select * from tblUKqCustomers
--using union keyword does two things
--1. sorts the resultset
--2. removes duplicates
--3. union uses 'distinct sort' for removing duplicates, 
--   hence the union is a little slower than union all

/*
Note:
1. For union and union all to work, the number of column, the datatype and the order of the columns
in the select statements must be same.
special case, if the two datatypes whose order of occurence in both the queries is different /is altered,
no error will occur if the data type is same.

2. the 'order by'  can be only be applied to the last select statement.
3. any number of select queries can be used.

*/

/*
Difference between union and join:
-----------------------------------
Union combines the result-set of two or more select queries into a single result-set which
includes all the rows from all the queries in the union,
where as,
Joins, retrieve data from two or more tables based on logical relationship between the 
tables.

In short, union combines rows from 2 or more tables, where joins combine columns from 2 or more tables.
*/

