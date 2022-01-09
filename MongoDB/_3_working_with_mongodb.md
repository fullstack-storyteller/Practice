# Working with MongoDB

## MongoDB Compass App

We can use the MongoDB Compass GUI application to work with MongoDB. The application is fairly self explanatory when you open it.

## MongoDB extension in VS Code

It is kind of the preferred way to work in MongoDB. Once installing the extension, open a new terminal and go to the following location `C:\Program Files\MongoDB\Server\5.0\bin` in command prompt.

After that you can run the command `mongo.exe` -> this will open the mongodb shell.

| Various Commands               | Details                                                                                                                                                                              |
| ------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `show dbs` or `show databases` | shows all the databases in the server                                                                                                                                                |
| `use <database-name>`          | creates a Database with name <database-name>. It will not be visible unless you insert some document inside it. Make sure you see the message **"switched to db \<database-name\>"** |
| `db`                           | shows the current database you are using                                                                                                                                             |
| `db.dropDatabase()`            | Here `db` refers to the current database. so this command will drop the current database and return result like `{"ok":1}`                                                           |
