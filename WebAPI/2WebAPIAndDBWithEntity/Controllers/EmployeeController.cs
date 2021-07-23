using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace _2WebAPIAndDBWithEntity.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET api/employee
        public IEnumerable<Employee> Get()
        {
            using(EmployeeDataModelEntities employees = new EmployeeDataModelEntities())
            {
                return employees.Employees.ToList<Employee>();
            }
        }

        // GET api/employee/1
        public Employee Get(int id)
        {
            using (EmployeeDataModelEntities employees = new EmployeeDataModelEntities())
            {
                return employees.Employees.FirstOrDefault<Employee>(x=> x.ID==id);
            }
        }
    }
}
