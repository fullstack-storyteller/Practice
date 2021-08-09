using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDataAccess;

namespace _2WebAPIAndDBWithEntity
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using(EmployeeDataModelEntities entities = new EmployeeDataModelEntities())
            {
                return entities.users.Any<user>(user => user.username
                    .Equals(username, StringComparison.OrdinalIgnoreCase) 
                        && user.password==password);
            }
        }
    }
}