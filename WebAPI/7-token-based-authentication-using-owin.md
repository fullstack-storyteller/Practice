# Implement token based Authentication in .NET Web API using OWIN Middleware and Identity Framework

Project: 3_WebApiTokenAuthenticationUsingOwin
Ensure to select Authentication using Individual User Accounts while creating the projects

![authentication](./images/35.png)

Follow the Project as is. Watch Kudvent's web api video starting video #20 onwards for more.

Check the Register.html page for code details, on how the validation is being done.

**Notes:**

- By Default, the data will be sotred in side the project itself, use `show all files` in solution explorer, and double click on the .mdf file to see more details. See Below:
  - ![stored data locally](./images/36.png)
- Upon clicking on the Register button the first time, the program took some additional time to return the results, that was because the program had to create the DB and then do the validation and insertion (if needed) of the data.
