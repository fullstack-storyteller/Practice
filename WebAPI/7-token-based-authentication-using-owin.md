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
- you can configure the automatically generated identity database

  - just go to the web.config file
  - select the desired server, and give proper file name or the database name(.mdf) and the make sure to give the initial catalog as the database name you just given or you can use your application database name(in this way the identity tables will be created inside the existing application database)
  - Cases:

    - To create the identity database in the project itself but different DB name (not the automated name):

      - Before

      ```xml
        <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-3_WebApiTokenAuthenticationUsingOwin-20210822102302.mdf;Initial Catalog=aspnet-3_WebApiTokenAuthenticationUsingOwin-20210822102302;Integrated Security=True" providerName="System.Data.SqlClient" />
      ```

      - After: identity database name is `myusers`

      ```xml
        <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myusers.mdf;Initial Catalog=myusers;Integrated Security=True" providerName="System.Data.SqlClient" />
      ```

    - To create the identity database in same server but different DB:

      - Before

      ```xml
        <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-3_WebApiTokenAuthenticationUsingOwin-20210822102302.mdf;Initial Catalog=aspnet-3_WebApiTokenAuthenticationUsingOwin-20210822102302;Integrated Security=True" providerName="System.Data.SqlClient" />
      ```

      ![before](./images/37.PNG)

      - After: the newly created identity database will be named myusers in your local db

      ```xml
        <add name="DefaultConnection" connectionString="Data Source=(Local);Initial Catalog=myusers;Integrated Security=True" providerName="System.Data.SqlClient" />
      ```

      ![after](./images/38.PNG)

    - To create the identity database in same server and same application DB:

      - Before

      ```xml
        <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-3_WebApiTokenAuthenticationUsingOwin-20210822102302.mdf;Initial Catalog=aspnet-3_WebApiTokenAuthenticationUsingOwin-20210822102302;Integrated Security=True" providerName="System.Data.SqlClient" />
      ```

      ![before](./images/37.PNG)

      - After

      ```xml
        <add name="DefaultConnection" connectionString="Data Source=(Local);Initial Catalog=practice;Integrated Security=True" providerName="System.Data.SqlClient" />
      ```

      ![before](./images/39.PNG)
