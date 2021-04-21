truncate table test2 --removed all the rows then
dbcc checkident('test2', reseed, 200) --reseeded the identity column starting value.


select IDENT_CURRENT('test1') --gives you last generated identity column value of any session of any table.
--any session any scope and any table



select * from test1
select * from test2
select SCOPE_IDENTITY() --same session same scope
select @@IDENTITY --same session any scope

insert into test1 values('manish1')
insert into test1 values('manish')
insert into test1 values('Archana')
insert into test1 values('Archana1')
insert into test2 values('Archana2')

--To understand the difference between scope_identity() method and @@identity global variable
--Lets write a trigger on test1, which makes sure when ever there is an insert in test1 table the test 2 table also populates
alter trigger tr_test1_for_insert on test1 for insert
as 
begin
	insert into test2 values('Test1 table inserted a value')
end


--create table test1(
--id int identity(100, 1) primary key,
--value nvarchar(50)
--)


--go
--create table test2(
--id int identity(100, 1) primary key,
--value nvarchar(50)
--)