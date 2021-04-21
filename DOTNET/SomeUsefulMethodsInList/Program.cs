using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace SomeUsefulMethodsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() { 
            ID = 101, Name = "Manish", Salary = 12000};

            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "My Love Archana",
                Salary = 13000
            };
            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "Archana",
                Salary = 14000
            };

            List<Customer> customers = new List<Customer>(100);// setting the initial capacity to 100 initially
            customers.Add(c3);
            customers.Add(c2);
            customers.Add(c1);

            Console.WriteLine("Are all Customers with Salary > 3000 = {0}", customers.TrueForAll(c => c.Salary > 3000));
            Console.WriteLine("Are all Customers with Salary > 12000 = {0}", customers.TrueForAll(c => c.Salary > 12000));
            //read it like customer c such that c.salary > 12000

            //TrueForALl() return a boolean value for the given predicate if all the elements in list follow a certain rule define by predicate.

            ReadOnlyCollection<Customer> readOnlyCustomers = customers.AsReadOnly();
            //readOnlyCustomers -> it doesn't have any Add or remove method
            // it can only be read now
            //readOnlyCustomers[0]
            //readOnlyCustomers.Count
            Console.WriteLine();
            Console.WriteLine("Total member in readOnlyCustomers {0}", readOnlyCustomers.Count);
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", readOnlyCustomers[0].ID, readOnlyCustomers[0].Name, readOnlyCustomers[0].Salary  );

            Console.WriteLine();
            Console.WriteLine("Capacity Before Trim Access method = {0}", customers.Capacity);
            customers.TrimExcess(); //this will trim the list capacity to only the number of element currently present.
            Console.WriteLine("Capacity Before Trim Access method = {0}", customers.Capacity);
            /*
             * This method(trimExcess ) can be used to minimize a collection's memory
             * overhead if no new element will be added to the collection.
             * the cost of reallocating and copying a large list <T> can be
             * considerable.
             * 
             * So the TrimExcess method does nothing if the list is at more than 90 % of the capacity.
             * This avoid incurring a large reallocation for a relatively smallaer gains.
             * The current threshold is 90%, but it can change in future.
             */

            Console.ReadKey();
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
