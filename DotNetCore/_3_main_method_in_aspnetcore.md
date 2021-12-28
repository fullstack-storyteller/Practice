# Main method of ASP .Net Core app

- Main method is the entry point of the ASP .Net Core web application
- ASP .Net core application initially starts as a Console application.
- Main methods configures the ASP .Net Core Application and then starts it and at that point it becomes an ASP .Net Core Web Application

```Example
namespace EmployeeManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
```
