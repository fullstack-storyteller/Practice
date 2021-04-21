--UTC stands for Coordinated Universal Time
/*
It is the time based on which the world regulates clocks and time.
There are slight differences in Greenwhich Mean Time (GMT) and UTC, but for most common purposes, UTC is synnomous to GMT
*/

/*
Some date and time datatypes:
*/
--create table datetimeFunctions(
--c_date date, --only containg the date in format either yyyy-mm-dd or any other arrangement
				--3 bytes
--c_time time, --only contains time hh:mm:ss.nnnnnnn format
				--3 to 5 bytes
--c_smalldatetime smalldatetime, --contains the smaller datetime string i.e. yyyy-mm-dd hh:mm:ss
				--4 bytes
--c_datetime datetime, --most common, containg system date time upto three nano seconds i.e. yyyy-mm-dd hh:mm:ss.nnn
				--8 bytes
--c_datetime2 datetime2, --more precision in nanoseconds for current system datetime. ie.e yyyy-mm-dd hh:mm:ss.nnnnnnn
				--6 to 8 bytes
--c_datetimeoffset datetimeoffset --provide UTC datetime plus the offset /deviation in hours:minutes.
				--8 to 10 bytes
				--precision is as follows, yyyy-mm-dd hh:mm:ss.nnnnnnn [[+]-]hh:mm
--)

--insert into datetimeFunctions values(getdate(), getdate(), getdate(), getdate(), getdate(), getdate())
select * from datetimeFunctions


/*
Some data and time methods:
*/
select getdate() 'getdate()' --give system date; most commonly used date time method
select CURRENT_TIMESTAMP 'CURRENT_TIMESTAMP' --ANSI SQL equivalent to getdate()
select SYSDATETIME() 'SYSDATETIME()' --more fractional seconds precision
select SYSDATETIMEOFFSET() 'SYSDATETIMEOFFSET()'--more fractional seconds precision + Time Zone offset
select getutcdate() 'getutcdate()'--UTC Date and Time
select SYSUTCDATETIME() 'SYSUTCDATETIME()'--UTC Date and Time with More fractional seconds precision, beware of the day light saivngs. The sql functions do not account for this.

/*
isdate(date time expression) -> if yes, then it will return 1, else 0
*/
select isdate('manish')--0
select isdate('02-1-2020') --1
select isdate('02-02-2020 03:00:00.234') --1
select isdate('02-02-2020 03:00:00.2342342') --0
--Note: isdate() return 0 for datetime2 datatype.

select day(getdate()) --returns day number of the month
select month(getdate()) --returns month number of the year
select year(getdate()) --returns year of the date

/*
DateName(DatePart, Date) - Returns a string (nvarchar), that represents a part of the given date.
This functions takes 2 parameters. The first parameters datePart specifies, the part of the date, we want.
The second parameter, is the actual date, from which we want the part of the fate.
*/

/*
Date part -- Abbreviation
-------------------------

year -- yy or, yyyy
quarter -- qq, or q
month -- mm, m
dayofyear -- dy, y
day -- dd, d
week -- wk, ww
weekday -- dw
hour -- hh
minute -- mi, n
second -- ss, s
millisecond -- ms
microsecond -- mcs
nanosecond -- ns
tzoffset -- tz

*/

select DATENAME(day, getdate()) 
select DATENAME(DW, getdate()) --name of the weekday
select DATENAME(weekday, getdate()) --name of the weekday
select DATENAME(MONTH, getdate()) --name of the month
select month(getdate()) --integer representation of the month

/*
it's better to use the full datepart in datename function.
*/

--create table TblEmpDOB(
--id int identity(1, 1) primary key,
--Name varchar(50),
--dob datetime
--)

--insert into TblEmpDOB values('manish', '06-01-1994 20:30:30')
--insert into TblEmpDOB values('kani', '11-10-1994 09:30:30')
--insert into TblEmpDOB values('Aditya', '03-11-1994 11:30:30')
--insert into TblEmpDOB values('sudha', '04-09-1994 15:30:30')
--insert into TblEmpDOB values('Poonam', '06-12-1994 12:30:30')
--insert into TblEmpDOB values('my Archana', '12-12-1980 08:45:00')

select 
Name, dob,
datename(DW, dob) 'day', 
datename(M, dob) 'Month',
month(dob) 'Month Number',
year(dob) 'Year'
from TblEmpDOB

/*
Datepart(datepart, date)
-> Returns an integer representing the specified datepart. this function is similar to
DateName(). DateName() returns nvarchar, where as datepart() returns an integer.
*/
select datepart(weekday, getdate())
select datepart(month, getdate())

/*
dateadd(datepart, number to add, date)
-> Returns the datetime, after adding specified NumberToadd, to the datepart specifed
of the given date
*/

select dateadd(day, 20, getdate())
select dateadd(day, -20, getdate())

/*
datediff(datepart, startdate, enddate)
-> returns the count of the specifed datepart boundaries crossed between the specified
start date and endadate
*/

select datediff(day, '11/11/2019 19:30:45', '12/12/2020')
select datediff(month, '11/11/2019 19:30:45', '11/10/2020')

select * from TblEmpDOB
select DATEDIFF(month, '2019-09-01', '2020-01-05')
select datediff(year, '11/30/2005', '01/31/2006') --say one year difference, which is incorrect, because the difference is 0 years 2 months
select datediff(month, '11/30/2005', '01/31/2006') --say two months difference, which is correct
select datediff(day, '11/30/2005', '01/31/2006') --say sixty two days difference, which is correct


select Name , dob, dbo.fnGetAge(dob) 'Age' from TblEmpDOB

--alter function fnGetAge(@dob datetime)
--returns varchar(50)
--begin
--declare @tempdate datetime, @year int, @month int, @days int
--set @tempdate =@dob

--set @year = DATEDIFF(year, @tempdate, getdate()) 
--			- 
--			case 
--				when (month(@dob)>month(getdate())) or (month(@dob) = month(getdate()) and day(@dob)> day(getdate()))
--				then 1 
--				else 0
--			end
--set @tempdate = dateadd(YEAR, @year, @tempdate)

--set @month = DATEDIFF(month, @tempdate, getdate())
--			-
--			case
--				when (DAY(@dob)>day(getdate()))
--				then 1
--				else 0
--			end
--set @tempdate =dateadd(month, @month, @tempdate)

--set @days = datediff(day, @tempdate, getdate())
--declare @age varchar(50)


--return cast(@year as varchar) + ' year(s), '+cast(@month as varchar )+' month(s), '+ cast(@days as varchar)+' day(s) old'

--end