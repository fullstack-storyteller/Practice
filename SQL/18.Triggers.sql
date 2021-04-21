--In SQL server there are 3 types of triggers
/*
1. DML Triggers
2. DDL Triggers
3. Logon Trigers
*/


/*
DML Triggers are filteres automatically in response to DML events (INSERT, UPDATE and DELETE)


DML triggers can be again classified into 2 types:
1. After triggers( Sometimes called as for triggers)
2. Instead of triggers

After triigers, fires after the triggering action.
The Insert, update or delete statements, causes an after trigger to fire after the respective statement
completes execution.

Instead of triggers, fiers instead of the triggereing action.
The Insert, update or delete statements, causes an Instead of trigger to fire instead of the respective 
statement execution.

*/
select * from tblEmployee
--drop table tblAudit
--create table tblAudit(
--id int primary key identity(1,1),
--AuditData nVarchar(500),
--dated datetime
--)

/*lets put some triggers on this table tblEMployee Audit table*/

--create trigger tr_tblEmployee_forInsert
--on tblEmployee
--for Insert
--as 
--begin
--	declare @id int
--	select @id= id from inserted
--	insert into tblAudit values('New Employee with Employee ID '+cast(@id as varchar)+ ' was inserted.', getdate())
--end


/*'Inserted' table is a special table which is only available in the context of a trigger.
it will contain the copy of the newly inserted row in the actual parent table on which the trigger is defined.
the structure of 'inserted' is identical to the table on which the trigger is defined.
*/
select * from department
select * from tblEmployee
insert into tblEmployee values( 'Inerted Employee', 'Male', 34550, 'London', 102, 2, 'test@t.com')

select * from tblAudit

/*after trigger for delete*/

--alter trigger tr_tblemployee_fordelete
--on tblEmployee
--for delete
--as 
--begin
--	declare @id int
--	select @id=id from deleted

--	insert into tblAudit values('Existing Employee with Employee ID '+cast(@id as varchar)+ ' was deleted.', getdate())
--end

/*'deleted' table is a special table which is only available in the context of a trigger.
it will contain the copy of the newly deleted row in the actual parent table on which the trigger is defined.
the structure of 'deleted' is identical to the table on which the trigger is defined.
*/

delete from tblEmployee where id =10

select * from department
select * from tblEmployee
select * from tblAudit

/*
After or For triggers for Update statements

*/

--create trigger tr_tblEmployee_forUpdate
--on tblEmployee 
--for Update
--as 
--begin
--	select * from inserted
--	select * from deleted
--end
exec sp_helpindex tblEmployee
drop index tblEmployee.ix_tblEmployee_gender_salar
drop index tblEmployee.uix_tblEmplpoyee_name_gender
drop index tblEmployee.ix_tblEmployee_name

select * from department
select * from tblEmployee
select * from tblAudit

/*initial testing with only select statement in the update trigger*/
update tblEmployee set Name = 'Manish',Gender= 'Male' , Salary=23452, department_id=102 where id=9 in (1, 2, 3)
/*
Inserted table contains:
ID	Name	Gender	Salary	City	department_id	manager_id	email
1	Manish	Female	23452	London	100	5	afdf@gmail.com


Deleted table contains:
ID	Name	Gender	Salary	City	department_id	manager_id	email
1	Tom	Male	4000	London	100	5	afdf@gmail.com
*/

--alter trigger tr_tblEmployee_forUpdate
--on tblEmployee 
--for Update
--as 
--begin
--	--select * from inserted
--	--select * from deleted
--	declare @id int
--	declare @old_name nvarchar(50), @new_name varchar(50)
--	declare @old_gender nvarchar(6), @new_gender nvarchar(6)
--	declare @old_deptID int, @new_deptID int
--	declare @old_salary int, @new_salary int

--	declare @audit_string nvarchar(200)

--	select * into #temp_trig_table_new from inserted

--	while(exists(select id from #temp_trig_table_new))
--	begin
--		select top 1 @id=ID, @new_deptID=department_id, @new_gender=Gender, @new_name=Name, @new_salary=Salary from #temp_trig_table_new
--		select @old_deptID = department_id, @old_gender=Gender, @old_name=Name, @old_salary=Salary from deleted where ID=@id
--		set @audit_string='Employee with ID '+cast(@id as varchar)+ ' changed '
--		if(@old_deptID<>@new_deptID)
--			set @audit_string =@audit_string + 'dept. from ' +cast (@old_deptID as varchar)+ ' to '+cast(@new_deptID as varchar)+','
--		if(@old_gender<>@new_gender)
--			set @audit_string =@audit_string + 'gender from ' +@old_gender+ ' to '+@new_gender+', '
--		if(@old_name<>@new_name)
--			set @audit_string =@audit_string + 'Name from ' +@old_name+ ' to '+@new_name+', '
--		if(@old_salary<>@new_salary)
--			set @audit_string =@audit_string + 'Salary from ' +cast (@old_salary as varchar)+ ' to '+cast(@new_salary as varchar)+'.'
--		insert into tblAudit values(@audit_string, GETDATE())

--		delete from #temp_trig_table_new where ID=@id
--	end

--end

select * from tblAudit
--select * from department
select * from tblEmployee
update tblEmployee set Name = 'Valerie1',Gender= 'Female' , Salary=25000, department_id=100 where id in (3, 4, 5 )

--truncate table tblAudit

