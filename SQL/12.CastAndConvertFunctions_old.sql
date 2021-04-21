/*
Syntax of cast and convert from MSDN

cast(expression as datatype[(length)])

convert(datatype[(length)]), expression [, style])
*/

select * from TblEmpDOB
select id, Name, dob, cast(dob as varchar) 'Casted DOB', convert(varchar, dob) 'Converted DOB' from TblEmpDOB
select id, Name, dob, cast(dob as varchar(5)) 'Casted DOB', convert(varchar(5), dob) 'Converted DOB' from TblEmpDOB

--just google date time style in google, and check out the msdn documentation

select id, Name, dob, cast(dob as varchar(8)) 'Casted DOB', convert(date, dob) 'Converted DOB' from TblEmpDOB
select id, Name, dob, cast(dob as varchar(8)) 'Casted DOB', convert(varchar, dob, 103) 'Converted DOB' from TblEmpDOB
select id, Name, dob, cast(dob as varchar(8)) 'Casted DOB', convert(date, dob, 103) 'Converted DOB' from TblEmpDOB--style ignored
/*
for converting to date datatype, the convert function will ignore the style parameter. so to control the style of date, make then convert to nvarchar or varchar
*/

select id, Name, cast(id as nvarchar)+Name 'ID-Name',dob, cast(dob as varchar(10)) 'Casted DOB', convert(varchar, dob, 103) 'Converted DOB' from TblEmpDOB