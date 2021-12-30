# ASP .Net Core launchsettings.json file

This file is only required in our local development machine and it is not needed for publishing our ASP .Net Core Application.

- If there are certain settings which we want our ASP .Net Core application to use when we publish and deploy our app, we can store those setting in the launchsettings.json file.

- We usually store our application configuration settings and environment specific details in this file.

- A sample file looks like below:

```json
{
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:54069",
      "sslPort": 0
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "EmployeeManagement": {
      "commandName": "Project",
      "launchBrowser": true,
      "applicationUrl": "http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
```

## **Note**

If you notice the launchSettings.json file, you will see that we have various `profiles` listed. These profiles will give specific information regarding the launch of the our application. The keys are self explanatory. The combination of `commandName` in launchSettings.json and `<AspNetCoreHostingModel></AspNetCoreHostingModel>` in .csproj or .vbproj file will determine which types of servers will be used. Please refer the below chart.

| `commandName` in launchSettings.json                                            | `AspNetCoreHostingModel` element in project file | Internal Web Server                    | External Web Server                        |
| ------------------------------------------------------------------------------- | ------------------------------------------------ | -------------------------------------- | ------------------------------------------ |
| `"Project"`, i.e. `EmployeeManagement` profile selected from the above example. | Hosting setting ignored                          | only one webserver - Kestrel           |                                            |
| `"IISExpress"` i.e. `IISExpress` profile selected from the above example.       | `InProcess`                                      | only one webserver - IIS Express       |                                            |
| `"IISExpress"` i.e. `IISExpress` profile selected from the above example.       | `OutOfProcess`                                   | internally kestrel server will be used | Externally IIS Express server will be used |
| `"IIS"` i.e. `IIS` profile selected from the above example.                     | `InProcess`                                      | only one webserver - IIS               |                                            |
| `"IIS"` i.e. `IIS` profile selected from the above example.                     | `OutOfProcess`                                   | internally kestrel server will be used | Externally IIS server will be used         |
