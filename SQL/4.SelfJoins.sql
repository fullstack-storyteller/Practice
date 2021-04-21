--select * from tblEmployee
	
--alter table tblEmployee add manager_id int default 5

--update tblEmployee set manager_id = 5 where id=1
--update tblEmployee set manager_id = 1 where id=2
--update tblEmployee set manager_id = 2 where id=3
--update tblEmployee set manager_id = 5 where id=4
--update tblEmployee set manager_id = null where id=5
--update tblEmployee set manager_id = 5 where id=6
--update tblEmployee set manager_id = 5 where id=7
--update tblEmployee set manager_id = 1 where id=8
--update tblEmployee set manager_id = 3 where id=9
--update tblEmployee set manager_id = 5 where id=10

select emp.id 'Emp ID', emp.Name 'Emp Name', isnull(mgr.id, -) 'Manager ID', isnull(mgr.Name , 'No Manager')'Manager Name'
from tblEmployee emp
left join tblEmployee mgr on emp.manager_id = mgr.ID
--removing null values using the isnull(expression, replacement value) function
--replacement value must have the same data type same as the expression.

select emp.id 'Emp ID', emp.Name 'Emp Name', coalesce(mgr.id, 0) 'Manager ID', coalesce(mgr.Name , 'No Manager')'Manager Name'
from tblEmployee emp
left join tblEmployee mgr on emp.manager_id = mgr.ID
--removing null using the coalesce() method
--this is a powerful method to return first non null values from the suppled parameters.
--coalesce function can take any number of arguments

select emp.id 'Emp ID', emp.Name 'Emp Name', case when mgr.id is null then 0 else mgr.ID end 'Manager ID', 
case when mgr.Name is null then 'No Manager'else mgr.Name end 'Manager Name'
from tblEmployee emp
left join tblEmployee mgr on emp.manager_id = mgr.ID
--removing null using the case when then end statement.


select emp.id 'Emp ID', emp.Name 'Emp Name', mgr.id 'Manager ID', mgr.Name 'Manager Name'
from tblEmployee emp
inner join tblEmployee mgr on emp.manager_id = mgr.ID

select emp.id 'Emp ID', emp.Name 'Emp Name', mgr.id 'Manager ID', mgr.Name 'Manager Name'
from tblEmployee emp
right join tblEmployee mgr on emp.manager_id = mgr.ID

select emp.id 'Emp ID', emp.Name 'Emp Name', mgr.id 'Manager ID', mgr.Name 'Manager Name'
from tblEmployee emp
full join tblEmployee mgr on emp.manager_id = mgr.ID

select emp.id 'Emp ID', emp.Name 'Emp Name', mgr.id 'Manager ID', mgr.Name 'Manager Name'
from tblEmployee emp
cross join tblEmployee mgr 