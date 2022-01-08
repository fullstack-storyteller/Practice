# MongoDB Basics

## What is a Database

- Database is a collection of data
- In the context of MongoDB:
  - Database can also be described as a physical container for collections
  - A database can have any number of collections
  - Each database gets its own set of files on the system
  - A MongoDB server can host multiple databases inside it

## What is a Collection

- Collection is a group of MongoDB Documents
- You can relate a collection as a "Table" (Not literally)
- Unlike tables in SQL, collections do not have any schema definition
- Unlike RDBMS Database - the collections DO NOT have any concept of JOINS
  - However we can acheive joins functionality using Aggregations in MongoDB

## What is a Document

- Document in MongoDB is a set of "Key-Value" pairs
- Every document in MongoDB has a unique value via **Key "\_id"**
- Documents have flexible and dynamic schema
- Documents schema is user-defined and is not Fixed or Static
- Documents can hold any data as long as they are valid data-types in MongoDB
- Documents within a collection can have different schema or fields
- Documents within a collection are related data belonging to a particular subject

| SQL                                                                                 | NoSQL                  |
| ----------------------------------------------------------------------------------- | ---------------------- |
| Examples: Oracle, MySQL, SQL Server, etc are relational database management systems | MongoDB is a non RDBMS |

| Database collection of tables | Database container of collections |
| Tables[entities: persons, objects, etc..] | | |
| Columns[fields insde the table like first name, last name] | |
| Rows[Actual data] | D |
