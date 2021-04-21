using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingUsing_Reflection
{
    public class Customer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        public Customer(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;

        }

        public string GetFullName()
        {
            return this.LastName + ", " + this.FirstName;
        }
    }
}
