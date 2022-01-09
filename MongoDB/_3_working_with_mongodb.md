# Working with MongoDB

## MongoDB Compass App

We can use the MongoDB Compass GUI application to work with MongoDB. The application is fairly self explanatory when you open it.

## MongoDB extension in VS Code and its shell commands

It is kind of the preferred way to work in MongoDB. Once installing the extension, open a new terminal and go to the following location `C:\Program Files\MongoDB\Server\5.0\bin` in command prompt.

After that you can run the command `mongo.exe` -> this will open the mongodb shell.

| Various Commands                        | Details                                                                                                                                                                                                                                                                                                                                                     |
| --------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `show dbs` or `show databases`          | shows all the databases in the server                                                                                                                                                                                                                                                                                                                       |
| `use <database-name>`                   | creates a Database with name "\<database-name\>" or if the database already exists, it simply switches to it. However, the newly creates DB will not be visible unless you insert some document inside it. Make sure you see the message **"switched to db \<database-name\>"**                                                                             |
| `db`                                    | shows the current database you are using or working space DB                                                                                                                                                                                                                                                                                                |
| `db.dropDatabase()`                     | Here `db` refers to the current database. So this command will drop the current database and return result like `{"ok":1}`                                                                                                                                                                                                                                  |
| `db.createCollection("CollectionName")` | This will create a new collection inside the current `db`. **Note**, This commands also allows the collection names to have space in between. This means, `db.createCollection("Peer Group")` is also valid. But Try to Avoid such a scenario as drop commands to such collection may give some errors and you will need to drop such collections from GUI. |
| `db.CollectionName.drop()`              | This will drop the collection inside the current `db`. **Note**, the name of the collection is case sensitive. It returns `true` when collection is deleted successfully and `false` when deletion not successful.                                                                                                                                          |
| `show collections`                      | This will show the list of collections inside the current `db`                                                                                                                                                                                                                                                                                              |
