using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using TeacherObject;

namespace Lesson4WCFDataContractsAndMembers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TeacherService : ITeacherService
    {
        public int InsertNewEmployee(TeacherItem teacher)
        {
            int result;
            using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("qi_Teacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@t_name", teacher.TeacherName);
                cmd.Parameters.AddWithValue("@deptID", teacher.Department.DeptID);
                cmd.Parameters.AddWithValue("@qual", teacher.TeacherQualification);
                //cmd.Parameters.AddWithValue("@salary", teacher.Salary);
                cmd.Parameters.AddWithValue("@gender", Convert.ToInt32(teacher.Gender));
                SqlParameter sqlParameter = new SqlParameter("@latestID", SqlDbType.Int);
                sqlParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(sqlParameter);
                if(teacher.GetType() == typeof(PartTimeTeacher))
                {
                    cmd.Parameters.AddWithValue("@hourlyPay", ((PartTimeTeacher)teacher).HourlyPay);
                    cmd.Parameters.AddWithValue("@hoursWorked", ((PartTimeTeacher)teacher).HoursWorked);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@annualSal", ((FullTimeTeacher)teacher).AnnualPackage);
                }
                cmd.Parameters.AddWithValue("@type", Convert.ToInt32( teacher.Type ));
                con.Open();
                cmd.ExecuteNonQuery();
                result=Convert.ToInt32( sqlParameter.Value.ToString());
            }
            return result;
        }

        public List<ListItem> ShowAllDepartments()
        {
            List<ListItem> departments;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("qs_getAllDeptarments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                departments = new List<ListItem>();
                while (sdr.Read())
                {
                    departments.Add(new ListItem(sdr["DEPT_NAME"].ToString(), sdr["DEPT_ID"].ToString()));
                }
            }

            return departments;
        }

        public TeacherItem ShowTeacherByID(int ID)
        {
            TeacherItem teacherItem = null;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("qs_getAllTeachersByID" , con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                //teacherItem = new TeacherItem();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    
                    if((EmployeeType) Convert.ToInt32( sdr["EmpType"]) == EmployeeType.FullTimeTeacher)
                    {
                        FullTimeTeacher teacher = new FullTimeTeacher();
                        teacher.TeacherName = sdr["TeacherName"].ToString();
                        teacher.TeacherQualification = sdr["TeacherQualification"].ToString();
                        teacher.Gender = (Gender)Convert.ToInt32(sdr["TeacherGender"]);
                        teacher.Type = (EmployeeType)Convert.ToInt32(sdr["EmpType"]);
                        teacher.AnnualPackage = Convert.ToInt32(sdr["TeacherSalary"]);
                        teacher.Department = new DepartmentItem() { DeptID=Convert.ToInt32(sdr["DeptID"]) ,Name = sdr["DepartmentName"].ToString() };
                        teacher.Success = true;
                        teacherItem= teacher;
                    }
                    else if((EmployeeType)Convert.ToInt32(sdr["EmpType"]) == EmployeeType.PartTimeTeacher)
                    {
                        PartTimeTeacher teacher = new PartTimeTeacher();
                        teacher.TeacherName = sdr["TeacherName"].ToString();
                        teacher.TeacherQualification = sdr["TeacherQualification"].ToString();
                        teacher.Gender = (Gender)Convert.ToInt32(sdr["TeacherGender"]);
                        teacher.Type = (EmployeeType)Convert.ToInt32(sdr["EmpType"]);
                        teacher.HourlyPay = Convert.ToInt32(sdr["HourlyPay"]);
                        teacher.HoursWorked = Convert.ToInt32(sdr["HoursWorked"]);
                        teacher.Department = new DepartmentItem() { DeptID = Convert.ToInt32(sdr["DeptID"]) , Name = sdr["DepartmentName"].ToString() };
                        teacher.Success = true;
                        teacherItem= teacher;
                    }
                    else
                    {
                        teacherItem = new TeacherItem();
                        teacherItem.Department = null;
                        teacherItem.TeacherName = string.Empty;
                        teacherItem.TeacherQualification = string.Empty;
                        teacherItem.Type = EmployeeType.NotProvided;
                        teacherItem.Success = false;
                        teacherItem.Gender = Gender.NotAvailable;
                        
                    }
                }
                
                //if (sdr.Read())
                //{
                //    teacher.TeacherName = sdr["TeacherName"].ToString();
                //    teacher.TeacherQualification= sdr["TeacherQualification"].ToString();
                //    //teacher.Salary = Convert.ToInt32(sdr["TeacherSalary"].ToString());
                //    teacher.Gender= (Gender)Convert.ToInt32( sdr["TeacherGender"]);
                //    teacher.Department = new DepartmentItem() { Name = sdr["DepartmentName"].ToString() };
                //    teacher.Success = true;
                //}
                //else
                //{
                //    //teacher.Salary = -999;
                //    teacher.
                //    teacher.TeacherName = string.Empty;
                //    teacher.Gender = Gender.NotAvailable;
                //    teacher.Department = null;
                //    teacher.TeacherQualification = string.Empty;
                //    teacher.Success = false;
                //}
            }

            return teacherItem;
        }
    }
}
