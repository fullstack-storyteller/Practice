# Introduction

The entire lessons of MONGODB is being studied from [this](https://www.youtube.com/watch?v=Ya0H-7A5cE4&list=PLp50dWW_m40UWFSV6PTgYzciZJIxgHy7Q&t=0s) course.

## Some Important Terminologies

- Database: Collection of data in a structured way
- SQL: Structured Query Language
- RDBMS: Relational Database Management System

## What is NoSQL

- NoSQL alias Non SQL alias Non Relational
- **In simple terms:** A NoSQL database is a Key-Value Database
- A NoSQL database provides:
  - A mechanism for storage and retrieval of data
  - The data is **NOT** modeled in _relational or tabular format_
  - A large variations and flavours of NoSQL are available in market - _MongoDB, Amazon DocumentDB, Google Datastore, Amazon DynamoDB etc_..
  - Extremely useful, powerful and high performance database in large bigdata applications, large distributed network architecture apps etc..

## What is MongoDB

- MongoDB is a free and open source cross platform Document-Oriented Database
- MongoDB is classified as NoSQL Database Program
- MongoDB uses JSON-like document with schemas

## What is Documetn Oriented Database

- A document-oriented database provides APIs or a query/update language that exposes the ability to query or update based on the internal structure in the document
- MongoDB documents are composed of fields-and-value pairs and have the following structure:

```json
{
    field1: value1,
    field2: value2,
    ....

}
```

## What MongoDB is NOT

- It is **NOT** a RDBMS
- it doesn't have any concept of joins. it does have a provision of aggregations to club collections. We will see it later.

## Ways to Install

There are 3 ways to install and use MongoDB

- Community Server
  - Visit the official [website](https://www.mongodb.com/try/download/community)
  - Install as instructed in the dialog box. and give host: `localhost` and port `27017` and connect. For now no authentication.
  - Download the latest stable version from the community server
- Visual Studio Extension
  - Here you can install the MongoDB extension in VS Code itself. Once done, you directly connect tthe same way as you have done earlier in the above step.
  - Once installed you can create new connection to your local or remote MongoDB server by using the connection string as `mongodb://localhost:27017`
- MongoDB Atlas
  - Cloud-hosted and fully managed MongoDB
  - Pay as you go model
  - Very cost-effective
  - Fully secured and reliable
  - nothing to be installed locally
