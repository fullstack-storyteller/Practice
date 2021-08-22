using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _3_WebApiTokenAuthenticationUsingOwin.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Authorize]
        public IEnumerable<Employee> LoadAllEmployees()
        {
            using(practiceEntities entities = new practiceEntities())
            {
                return entities.Employees.ToList<Employee>(); 
            }
        } 
    }
}
