# Sorting in MongoDB

- We must sort the record set before passing it to next logical operation
- To sort we can use the below command
  - `db.CollectionName.find().sort({"fieldToBeUsedForSorting":1})`
  - 1: means ascending
  - -1: means descending
  - Example 1: `db.Family.find().sort({"name":1}).pretty()`
  - Example 2: `db.Family.find().sort({"Salary":-1}).pretty()`

## Why Indexes

- Indexes are the fastest way to find information
  - Relate it to the index page in your book
- Index concept is same as that you already would know in SQL
- By default - every collection will have an index on "\_id" key
- Example of creating an index: `db.Family.ensureIndex("fieldUponWhichIndexNeedsToBeCreated":1)`
