using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace IndexersInCSharp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session is an indexer
            Session["Session1"] = "Session 1 Data";
            Session["Session2"] = "Session 2 Data";

            Response.Write("Session 1 Data: "+ (string)Session[0]);
            Response.Write("<br/>");
            Response.Write("Session 2 Data: " + (string)Session["Session2"]);
            Response.Write("<br/>");

            string connectionstring = ConfigurationManager.ConnectionStrings["DBConnection4"].ConnectionString;
            using(SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                SqlCommand sqlCommand = new SqlCommand("qs_getEmployees", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Response.Write("ID = "+sqlDataReader[0].ToString() );
                    Response.Write(" Name = " + sqlDataReader["employee_name"].ToString() + "<br/>");
                    //see how the indexer sqlDataReader is being used

                }


                //from the above example, it should be clear that Indexers allow instances of a class to be indexed just like arrays 
            }

            Company company = new Company();
            Response.Write("Name of the Employee with ID = 2: " + company[2]);
            Response.Write("<br/>");

            Response.Write("Name of the Employee with ID = 5: " + company[5]);
            Response.Write("<br/>");

            Response.Write("Name of the Employee with ID = 8: " + company[8]);
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("Changing name of the employees 2, 5, 8<br/>");

            company[2] = "Heyo!";
            company[5] = "Hola!";
            company[8] = "Archana I love you";

            Response.Write("Name of the Employee with ID = 2: " + company[2]);
            Response.Write("<br/>");

            Response.Write("Name of the Employee with ID = 5: " + company[5]);
            Response.Write("<br/>");

            Response.Write("Name of the Employee with ID = 8: " + company[8]);
            Response.Write("<br/>");

            Response.Write("<br/>");

            Response.Write("Total number of Male employee =" + company["Male"] + "<br/>");
            Response.Write("Total number of Female employee =" + company["Female"] + "<br/>");

            Response.Write("Changing All male employee's gender to Female"  + "<br/>");
            company["Male"] = "Female";
            Response.Write("Total number of Male employee =" + company["Male"] + "<br/>");
            Response.Write("Total number of Female employee =" + company["Female"] + "<br/>");
        }


    }
}