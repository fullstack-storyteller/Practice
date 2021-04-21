using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceWithAjax
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary{ get; set; }
        public string Address { get; set; }
        public bool SuccessFlag { get; set; }
    }
}