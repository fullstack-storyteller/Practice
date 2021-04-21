
/*
ASCII(character expression) returns the ascii code value if a charact
*/
select ASCII('A')

/*
char(integer Expression) returns the character from the ascii code value
*/
select char(65)
declare @start int =65
while(@start <=90 )
begin
	select char(@start)
	set @start=@start+1
end

/*ltrim(character expression) trims spaces from the left of the character expression*/
select ltrim('   Manish ')

/*rtrim(character expression) trims spaces from the right of the character expression*/
select rtrim('     Manish   ')
select ltrim(rtrim('   Manish   '))

/*
upper(charater expression)-> makes everything upper case
lower(charater expression)-> makes everything lower case
*/
select upper('Upper')
select lower('Upper')

/*
reverse(Any string expression)-> reverses the characters
*/
select REVERSE('Manish')

/*
len(string expression) ->  returns the total count of characters in the string expression
							but it excludes the blanks / spaces at the end of the string 
							expression.
*/
select(len('  Manish '))

/*
left(charcter expression, integer expression)
-> retrieve supplied number character from left of the character expression
*/

select left('ABSCS',2)

/*
right(charcter expression, integer expression)
-> retrieve supplied number character from right of the character expression
*/

select right('ABSCS',2)

/*
charindex('Expression to find', 'Expression to search', 'start location')
-> returns the starting position of the specified expression in a character string
-> start location is optional.
-> returns zero if nothing found.
PS, the index of characters in sql, starts at 1
*/
select charindex('@', 'sara@aaa.com') --5
select charindex('s', 'sara@aaa.com') --1
select charindex('@', 'sara@aaa.com',6) --0

/*
substring('Expression', start, length)
-> returns substring from the given expression
*/
select SUBSTRING('sara@aaa.com', CHARINDEX('@', 'sara@aaa.com')+1, len('sara@aaa.com') - CHARINDEX('@', 'sara@aaa.com'))

select * from tblEmployee 
--alter table tblEmployee add email varchar(30)
--update tblEmployee set email = 'afdf@gmail.com' where id =1
--update tblEmployee set email = 'basd@gmail.com' where id =2
--update tblEmployee set email = 'cfdfd@gmail.com' where id =3
--update tblEmployee set email = 'zwerw@gmail.com' where id =4
--update tblEmployee set email = 'rwer@outlook.com' where id =5
--update tblEmployee set email = 'a@outlook.com' where id =6
--update tblEmployee set email = 'r@outlook.com' where id =7
--update tblEmployee set email = 'arerrwe@yahoo.com' where id =8
--update tblEmployee set email = 'awqq@yahoo.com' where id =9
--update tblEmployee set email = 'aas@yahoo.com' where id =10

select SUBSTRING(email, CHARINDEX('@', email)+1, len(email) - CHARINDEX('@', email)) as Email, count(1) as Total  from
tblEmployee
group by SUBSTRING(email, CHARINDEX('@', email)+1, len(email) - CHARINDEX('@', email)) 

/*space(number of spaces)-> return the number of spaces*/
select 'Manish' +space(5)+'Kumar'+space(5)

/*
Replicate(string_to_be_replecated, number_of_times_to_replicate)
-> repeats the given string for the specified number of times
*/

select REPLICATE('Manish Ji ', 3)
select Name, email, 
(
substring(email, 1, 2) + replicate('*', 5)+ '@'+SUBSTRING(email, CHARINDEX('@', email)+1, len(email) - CHARINDEX('@', email)) 
) as encrypted_email
from tblEmployee

/*
patindex('%Pattern%', expression)
-> returns the starting position of the first occurence of a pattern in a specified expression.
It takes two arguments, the pattern to be searched and the expression.
-> it is similar to charindex().
-> With charindex() we cannot use wild cards, where as patindex() provides this capability.
-> return zero is specified pattern is not found.

*/

select email , PATINDEX('%gmail.com%', email) 'First Occurence' from tblEmployee
where PATINDEX('%gmail.com%', email)>0

/*
Replace(string_expression, pattern, replacement_value)
-> Replace all occurences of a specified string value with another string value
*/

select name, email, REPLACE(email, 'com', 'net') as replaced_email
from tblEmployee

/*
stuff(Original_Expression, start, Length, Replacement_expression)
-> it inserts Replacement_expression, at the start position specified, along with
	removing the characters specifed using length parameter.
*/

select name, email, STUFF(email, 2, 4, REPLICATE('/', 6)) 'Stuffed Email' from tblEmployee