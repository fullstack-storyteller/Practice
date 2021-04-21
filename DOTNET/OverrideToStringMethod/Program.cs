using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideToStringMethod
{
    class Program
    {
        /*
         * 
         * ToString method can convert numbers, character to string but it can't convert Type.
         * To get a user required way of converting and using the object (Complex Type) , we can however 
         * override the tostring method.
         * Below is an example:
         * 
         * 
         */
        static void Main(string[] args)
        {
            //int num = 10; 
            //Console.WriteLine(num.ToString()); //this is before we override the ToString Method
            Customer c1 = new Customer();
            c1.FirstName = "Manish";
            c1.LastName = "Kumar";
            /*Console.WriteLine(c1.ToString());*/ //output: OverrideToStringMethod.Customer 
            //the above output calls for overriding the Tostring mehtod

            //after override
            Console.WriteLine(c1.ToString()); 
            //Note, c1.ToString() will throuw an error / exception when a it is called on c1 when it is null
            //or you can you the below 

            Console.WriteLine(Convert.ToString(c1)); //both of these will work
            //Note, this will convert the empty  / null c1 into a empty string. it will not throw any exception

            //you both of them wisely


            Console.ReadKey();

        }
    }
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return this.LastName + ", " + this.FirstName;
        }
    }
}
