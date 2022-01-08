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
