# Data Types in MongoDB

Below data types are available in MongoDB:

- BSON
- JSON
- Integer
- Boolean
- Double
- Arrays
- Object
- Null (no value for a key)
- Date
- Timestamp
- Object Id
- Code

## Difference between BSON and JSON

- JSON based databases usually return query results which can be effortlessly parsed, having modest or nix transformation, straightforward with the help of JavaScript along with most-used programming languages.
- In the case of MongoDB, data representation is done in JSON document format, but here the JSON is binary-encoded, which is termed as BSON.
- BSON is the extended version of the JSON model, which is providing additional data types, makes performace to be competent to encode and decode languages and ordered fields.
- BSON has some extended data types which are not supported by JSON
  - date
  - timestamp
  - Object id

## What is Projection in MongoDB

- Projection is nothing but another name for selecting the fields for showing or hiding the data
  - We need to specifiy the field as "1" or "0". Example: `db.Family.find({},{"name":1,"Salary":1, "_id":0}).pretty()`
  - If we don't specify the projection, then it will display every possible field
- What happens under the hood?
  - MongoDB gets all the documents
  - finds matching document according to the filter criteria
  - Extract the keys / fields that are included in the projection or that we asked for
  - display the result
  - By default, if nothing is included in projection, everything will be returned and displayed.
