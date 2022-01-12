# Sorting in MongoDB

- We must sort the record set before passing it to next logical operation
- To sort we can use the below command
  - `db.CollectionName.find().sort({"fieldToBeUsedForSorting":1})`
  - 1: means ascending
  - -1: means descending
  - Example 1: `db.Family.find().sort({"name":1}).pretty()`
  - Example 2: `db.Family.find().sort({"Salary":-1}).pretty()`
