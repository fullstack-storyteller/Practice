/*
A view is just a virtual table.

A standard or non indexed view is just a stored sql query. When, we try to retieve data from the view, 
the data is actually retieved from the underlying base tables.
So, a view is just a virtual table, and it doesn't store any data, by default.

However, when you create an index, on a view, the view gets materialized. This means,
the view is now, capable of storing the data.

in SQL server, we call them Indexed view
in Oracle we call them Materialized Views
*/

--create table ProductDetails(
--product_id int identity(1, 1) primary key,
--product_name varchar(100) Not null,
--unit_price int not null
--)

--create table ProductSales(
--product_id int not null,
--quantity_sold int not null
--)

--insert into ProductDetails values('Books', 20)
--insert into ProductDetails values('Pens', 14)
--insert into ProductDetails values('Pencils', 11)
--insert into ProductDetails values('Clips', 10)

--insert into ProductSales values(1, 10)
--insert into ProductSales values(3, 23)
--insert into ProductSales values(4, 21)
--insert into ProductSales values(2, 12)
--insert into ProductSales values(1, 13)
--insert into ProductSales values(3, 12)
--insert into ProductSales values(4, 13)
--insert into ProductSales values(1, 11)
--insert into ProductSales values(2, 12)
--insert into ProductSales values(1, 14)



select pd.product_name 'Product Name', sum(pd.unit_price*ps.quantity_sold) 'Total Sales', 
		sum(ps.quantity_sold) 'Quantity Sold', count_big(1) 'Total Transactions'
from ProductDetails pd 
inner join ProductSales ps on pd.product_id = ps.product_id
group by pd.product_name

alter view vw_TotalSaleByProduct
with schemabinding --using schema binding is necessary for indexed view
as
select pd.product_name 'Product Name', sum(isnull(pd.unit_price*ps.quantity_sold, 0)) 'Total Sales', 
		sum(isnull(ps.quantity_sold,0)) 'Quantity Sold', count_big(*) 'Total Transactions'
from dbo.ProductDetails pd 
inner join dbo.ProductSales ps on pd.product_id = ps.product_id
group by pd.product_name

/*
To create a indexed view the below rules should be followed:
1. the view should be created with schemabinding option
2. If an aggregate function in the select statement, references an expression, and if there is a 
possibility for that expression to become null, then, a replacement value should be specified.
3. If group by is specified, the view select list must contain a count_big(*) expression. necenssaary because (count_big(1)) will not work
4. the base tables in the view, should be be refereenced with 2 part name, like dbo.table_name
not 3 part name not 4 part name, but only two part name, i.e schema.table-name

*/
select * from vw_TotalSaleByProduct

--create unique clustered index uix_vw_TotalSaleByProduct_ProductName
--on vw_TotalSaleByProduct([Product Name] desc)

/*
Why Clustered index?
well non clustered index require data, and anyways it should be noted that the first 
index which you are creating should be a clustered index
*/

/*
Note: indexed views are suitable in places where the data doesn't change frequently
Note: Cost of maintaining indexed views is more more thatn cost of maintaining an indexed table.
*/

 /*
 View Limitations:
 */

 --You can't pass parrameters to a view. Table valued functions are an excellent replacement for parameterized views

 --Rules and defaults can't be associated with views

 --views can not be based on temporary tables

 --the order by clause is invalid in views unless TOP or FOR XML is also used.