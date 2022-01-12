# Aggregation in MongoDB

- Aggregate is very similar to the find command, where you can provide the criteria for you query in the form of JSON documents
- The key element in aggregation is called the pipeline
- It also helps us in performing few operations like min, max, sum, etc..
- The command to use Aggregation is:
  - Example: `db.Family.aggregate(pipeline, options)`

```mongodb

var pipeline=[
    {$sort:{"name":1}},
    {$limit:2}
];
db.Family.aggregate(pipeline).pretty();

```

## What is a pipeline

- A sequence of data aggregation operations or stages. Please refer below:
  - $count
  - $group
  - $limit
  - $lookup
  - $match
  - $merge
  - $sort
  - $project
  - $unwind
  - $unset
  - and many more
- it is an array of operations/stages

## What are Options

- Documents can be passed as well
