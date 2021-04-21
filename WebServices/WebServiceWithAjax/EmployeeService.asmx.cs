using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WebServiceWithAjax
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://Manish.Kumar.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public Employee GetEmployeeByID(int id) //still you need to managed the non integers supplied paramters
        {
            Employee employee;
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("qs_getEmployeeByID", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                employee = new Employee();

                if (sdr.Read())
                {
                    employee.Address = sdr["employee_address"].ToString();
                    employee.Id = Convert.ToInt32(sdr["employee_id"].ToString());
                    employee.Name = sdr["employee_name"].ToString();
                    employee.Salary = float.Parse(sdr["employee_salary"].ToString());
                    employee.SuccessFlag = true;
                }
                else
                {
                    employee.Address = string.Empty;
                    employee.Id = -1;
                    employee.Name = string.Empty;
                    employee.Salary = -999;
                    employee.SuccessFlag = false;
                    

                }

            }

            return employee;
        }
    }
}
