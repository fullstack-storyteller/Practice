
--create table tblDepartment(
--id int primary key identity(100, 1),
--name varchar(100) not null
--)

--create table tblTeacher(
--id int primary key identity(1, 1),
--name varchar(100) not null,
--department int foreign key references tblDepartment(id),
--qualification varchar(20),
--salary int default 100000*rand(),
--gender varchar(6)
--)
--drop table tblTeacher



--insert into tblDepartment values('Physics')
--insert into tblDepartment values('Chemistry')
--insert into tblDepartment values('Mathematics')
--insert into tblDepartment values('Social Studies')
--insert into tblDepartment values('Biology')
--insert into tblDepartment values('Pyschology')
--insert into tblDepartment values('Sociology')

select * from tblDepartment
select * from tblTeacher

--insert into tblTeacher(name, department, qualification, gender) values('Manish Kumar', 100, 'PHD', 'Male')
--insert into tblTeacher(name, department, qualification , gender) values('Manisha Kumari', 101, 'PHD', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Tarun Kumar', 102, 'MTech', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Archana Verma', 103, 'MTech', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Pawan Sharma', 104, 'MTech', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Test User', 105, 'PHD', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Hema Kumari', 106, 'BTech', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Manisha Verma', 100, 'BTech', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Karun Sharma', 101, 'PHD', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Testing Talk', 102, 'PHD', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Manika Kumari', 103, 'MTech', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Nitish Kumar', 104, 'BTech', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Praveen Kumar', 105, 'BTech', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Abhimanyu Kumar', 106, 'PHD', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Ramesh Kumar', 100, 'MTech', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Ramesh Rajaram', 101, 'MTech', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Tashi Verma', 102, 'BTech', 'Female')
--insert into tblTeacher(name, department, qualification, gender) values('Taylor Lautner', 103, 'BTech', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Christoher Praveen', 104, 'MTech', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Toffy Trimp', 105, 'BTech', 'Male')
--insert into tblTeacher(name, department, qualification, gender) values('Chris Parekh', 106, 'PHD', 'Male')


select t.name, t.qualification, d.name, t.gender, t.salary
from tblTeacher t 
inner join tblDepartment d on t.department=d.id

select d.name 'Departments', COUNT(1) 'TeachersPerDept'
from tblTeacher t 
inner join tblDepartment d on d.id =t.department
group by d.name
having COUNT(1) >= 3
order by Departments desc