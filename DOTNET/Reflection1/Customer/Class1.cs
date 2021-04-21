using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Customer
{
    public class CustomerDetails
    {
        public int ID { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }

        public CustomerDetails()
        {
            this.ID = -1;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
        }
        public CustomerDetails(int id, string fname, string lname)
        {
            this.ID = id;
            this.LastName = lname;
            this.FirstName = fname;
        }

        public void PrintCustomerName( string x, int y, bool j)
        {
            Console.WriteLine("Cutomer Name = {0}, {1}",this.LastName, this.FirstName);
        }
        public void PrintCustomerID()
        {
            Console.WriteLine("Cutomer ID = {0}", this.ID);
        }

    }
}
