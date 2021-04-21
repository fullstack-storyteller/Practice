/*
ABS(numeric expression)-> returns the abosulte number (positive)
*/

select abs(23.5), abs(-1)

/*
Ceiling(numeric expression) -> smallest integer greater than or equal to suplied value 
floor(numeric expression) -> largest integer less than or equal to supplied value
*/

select CEILING(24.5), floor(24.5)
select CEILING(-24.5), floor(-24.5)

/*
Power(expression, power)
*/
select POWER(9, 3)

/*
square(number) -> return square
sqrt(number) -> square root
*/
select square(11.6), sqrt(12.4)

/*
Rand([seed value]) -> return a random number between 0 and 1
seed value -> is optional, but if it supplied, the rand() will give same result everythime
*/
select rand() 'rand()' --0.87499527410411
select floor(rand()*10) 'floor(rand()*10)' --0.87499527410411
select rand(23) 'rand(23)' --0.714001918580604

--script to print 10 random number bewteen 0 and 1000
declare @counter int =0
while @counter <10
begin
print floor(rand()*1000)
set @counter =@counter+1
end

/*
Round(numeric expression, length, [, function])
->Rounds the given number / numeric expression based on the given length.
This function takes 3 parameters.
1. Numeric expression
2. length parameter specifies the number of digits that we want to round.
	if length is positive the rounding is applied to the decimal part
		else, it applied to the number present before the decimal
3. The optional function parameter, is used to indicate rounding or truncation operation
	Zero-> indicates rounding. this is also the default value.
	non Zero indicates truncation
*/

select round(850.556, 2) --850.560
select round(850.556, 2, 1) --850.550
select round(850.556, 1) --850.600
select round(850.556, 1, 3) --850.500
select round(850.556, 1, 0) --850.600

select round(850.556, -2) --900.000
select round(850.556, -1) --850.000
select round(850.556, -2, 1) --800.000
select round(850.556, -1, 4) --850.000


