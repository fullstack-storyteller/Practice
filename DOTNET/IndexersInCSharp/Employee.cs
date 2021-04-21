using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndexersInCSharp
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployee;

        public Company()
        {
            listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { EmployeeID = 1, Gender = "Male", Name = "Archana" });
            listEmployee.Add(new Employee() { EmployeeID = 2, Gender = "Female", Name = "Savitri" });
            listEmployee.Add(new Employee() { EmployeeID = 3, Gender = "Male", Name = "Ranjith" });
            listEmployee.Add(new Employee() { EmployeeID = 4, Gender = "Female", Name = "Pooja" });
            listEmployee.Add(new Employee() { EmployeeID = 5, Gender = "Male", Name = "Manish" });
            listEmployee.Add(new Employee() { EmployeeID = 6, Gender = "Male", Name = "Poonmam" });
            listEmployee.Add(new Employee() { EmployeeID = 7, Gender = "Female", Name = "Aman" });
            listEmployee.Add(new Employee() { EmployeeID = 8, Gender = "Female", Name = "Deepshikha" });
            listEmployee.Add(new Employee() { EmployeeID = 9, Gender = "Female", Name = "Sapna" });
        }

        //let's create an indexer.
        //this is done using the this keyword
        public string this[int x]
        {
            get
            {
                return listEmployee.FirstOrDefault(emp => emp.EmployeeID == x).Name;
                //return first or default from list employee such that for a given employee, employee ID ==x(supplied value;)
            }
            set
            { 
                listEmployee.FirstOrDefault(emp => emp.EmployeeID == x).Name = value;
                //first find the employee object to be updated using the value x,
                // find first or default from the list employee such that emp. id = x , 
                // once the item has been identified, set the name to something supplied from the user.
            }
        }
        public string this[string type]
        {
            get
            {
                return listEmployee.Count(emp => emp.Gender == type).ToString();
            }
            set
            {
                foreach(Employee emp in listEmployee)
                {
                    emp.Gender = type;
                }
            }
        }
    }
}