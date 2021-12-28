# ASP .Net Core Project File

- .csproj for C# based web app and .vbproj for VB based web app
- The format and content written in this file has significantly changed in .Net Core
- In previous .Net Projects, we could edit the .csproj or .vsproj file only after unloading the project from Solution Explorer and then opening the file. In .Net Core, we we can simply right click on the Project and then select Edit Project File
- File or Folder references are no longer included in the project file. In older versions whenever we used to add new files or Items in the project, a reference of the same was added to this project file
- The File System determines what files and folders belong to the project. You can test this by simply placing a file in the root folder in Windows Explorer and see it will get reflected in the Solution Explorer for that project. If you delete it from the Windows Explorer, the same will be deleted from the project also.
  - ![check](./images/1.png)
