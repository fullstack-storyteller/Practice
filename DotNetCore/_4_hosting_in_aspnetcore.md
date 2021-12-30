# ASP .Net Core Hosting

Once you successfully developed your web application, what should be the next step you have to do? The answer is `Hosting`. We have to host our application to the server so that other people can access it. The process of deploying/installing an application into the server is called **Hosting**.

Whenever you create an ASP.NET Core application, by default it contains an internal server provided by a .NET Core that is called Kestrel. Due to this server, we can run ASP.NET Core apps on any platform like Windows, Mac or Linux. Before getting into the details about hosting models, let's first see what is the Kestrel server.

## What is the Kestrel Server?

Kestrel is a cross-platform web server for ASP.NET Core. Kestrel is the webserver that's included by default in ASP.NET Core project templates.

Kestrel is based on the [libuv](https://github.com/libuv/libuv) library, the same library which is used by Node.

Some features of Kestrel:

- It supports SSL
- lightweight
- cross-platform

## Hosting Models in ASP.NET Core

There are 2 types of hosting models in ASP.NET Core i.e In-process Hosting and Out-of-process Hosting. Before ASP.Net Core 2.2 we have only one hosting model which is Out-of-process but after due to the performance we have In Process Hosting Model in 2.2+ versions.

## InProcess Hosting

- **Default** hosting model in ASP .Net Core 3.1 onwards.

## OutOfProcess Hosting

In OutOfProcess hosting models, we can either use the Kestrel server directly as a user request facing server or we can deploy the app into IIS which will act as a proxy server and sends requests to the internal Kestrel server. In this type of hosting model we have two options:

- Using Kestrel: So in this type Kestrel itself acts as edge server which directly server user requests. It means that we can only use the Kestrel server for our application.

  - ![kestrel](./images/1.png)

-

- **Default** hosting model in ASP .Net Core earlier version.
