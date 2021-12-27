# Introduction to .NET Core

We will learn the following in this series:

1. ASP .Net Core
2. ASP .Net Core MVC
3. ASP .Net Core Identity
4. Entity Framework Core

## What is ASP .Net Core

- ASP .Net Core is a cross-platform, high-performance, open-source framework for building modern, cloud-based, internet-connected applications

- ASP .Net Core is a redesign of ASP .Net 4.x

## ASP .Net Core Benefits and Features

- Cross Platform

  - ASP .Net Core applications can be developed and run accross different platforms like
    - Windows
    - macOS
    - Linux
  - ASP .Net Core appications can be hosted on
    - IIS
    - Apache
    - Docker
    - Self-host in your own process
  - From a development standpoint you can either use visual studio or visual studio code or even sublime (3<sup>rd</sup> party edtior)

- Unified or One Programming Model for MVC and Web API

  - Both the MVC Controller class and the ASP .Net Web API Controller class inherit from the same `Controller` base class and return `IActionResult`.
  - IActionResult has many implementations like ViewResult and JsonResult.

- Dependency Injection
  - ASP .Net Core has built-in support for dependency injection
  - We will discuss this at length
- Testability
- Open Source and Community focused
