using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace _2WebAPIAndDBWithEntity.Controllers
{
    [RequireHttps]
    public class EmployeeController : ApiController
    {
        // GET api/employee
        [HttpGet]
        //public IEnumerable<Employee> LoadAllEmployees()
        //{
        //    using(EmployeeDataModelEntities employees = new EmployeeDataModelEntities())
        //    {
        //        return employees.Employees.ToList<Employee>();
        //    }
        //}
        public HttpResponseMessage LoadAllEmployees(string gender = "All")
        {
            using (EmployeeDataModelEntities entities = new EmployeeDataModelEntities())
            {
                switch (gender.ToLower())
                {
                    case "all": return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.ToList<Employee>());
                    case "male": return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where<Employee>(x => x.Gender.ToLower() == "male").ToList<Employee>());
                    case "female": return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where<Employee>(x => x.Gender.ToLower() == "female").ToList<Employee>());
                    default: return Request.CreateErrorResponse(HttpStatusCode.BadRequest, string.Format("The gender parameter only accepts All, Male or Female. {0} is invalid.", gender));
                }
            }
        }

        // GET api/employee/1
        [HttpGet]
        public HttpResponseMessage LoadEmployeeByID(int id)
        {
            
            using (EmployeeDataModelEntities employees = new EmployeeDataModelEntities())
            {
                Employee emp= employees.Employees.FirstOrDefault<Employee>(x => x.ID == id);

                if (emp != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, emp);
                }
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, string.Format("Employee with ID {0} is not found.", id));

            }
               
            
            
        }

        //POST api/employee
        //[FromBody] instructs the employee controller that the request will have data in its body
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try
            {
                using(EmployeeDataModelEntities entities = new EmployeeDataModelEntities())
                {
                    //at this stage employee doesn't have an id
                    entities.Employees.Add(employee);
                    entities.SaveChanges();
                    //as soon as the employee is saved, we have an employee id

                    //its a good practice to return the uri for the newly created item
                    return Request.CreateResponse(HttpStatusCode.Created, Request.RequestUri +"/"+ employee.ID.ToString());

                }
                
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //delete api/employee/1
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (EmployeeDataModelEntities entities = new EmployeeDataModelEntities())
                {
                    Employee emp = entities.Employees.FirstOrDefault<Employee>(x => x.ID == id);
                    if (emp != null)
                    {
                        entities.Employees.Remove(emp);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, string.Format("Employee with ID {0} deleted.", id));
                    }
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, string.Format("Employee with ID {0} not deleted as it was not found.", id));
                }
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
        }

        //in the below we are getting employee from from request body
        public HttpResponseMessage Put(int id, [FromBody] Employee employee)

        //lets switch, we will get employy from request uri and id from request body
        //public HttpResponseMessage Put([FromBody] int id, [FromUri] Employee employee)
        {
            try
            {
                using (EmployeeDataModelEntities entities = new EmployeeDataModelEntities())
                {
                    Employee emp = entities.Employees.FirstOrDefault<Employee>(x => x.ID == id);
                    if (emp != null)
                    {
                        emp.FirstName = employee.FirstName;
                        emp.Gender = employee.Gender;
                        emp.LastName = employee.LastName;
                        emp.Salary = employee.Salary;

                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, emp);
                    }
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, string.Format("The Employee with ID {0} is not found.", id));
                }
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }
    }
}
