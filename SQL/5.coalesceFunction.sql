drop table Names

create table Names(
id int identity(1, 1),
firstName varchar(10),
middleName varchar(10),
lastName varchar(10),
)

insert into Names values('Sam', null, null)
insert into Names values(null, 'Todd', 'Tarzan')
insert into Names values(null, null, 'Sara')
insert into Names values('Ben', 'Parker', null)
insert into Names values('James', 'Nick', 'Nancy')

select id, coalesce(firstName, middlename, lastname) 'Name' from Names