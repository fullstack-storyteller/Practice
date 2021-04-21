using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                ID = 101,
                Name = "Archana",
                Salary = 12300
            };
            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "Akila",
                Salary = 13300

            };
            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "Archana My love",
                Salary = 14300
            };

            Customer[] customers = new Customer[3];
            customers[0] = c1;
            customers[1] = c2;
            customers[2] = c3;
            List<Customer> customers1 = new List<Customer>(2); //gave an initial size of 2
            //but a list can grow more than that too
            customers1.Add(c1);
            customers1.Add(c2);
            customers1.Add(c3);
            Customer c = customers1[0]; //list can be accessed using indices
            Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            Console.WriteLine();

            for(int i =0; i<customers1.Count; i++)//foreach is preferable
            {
                Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", customers1[i].ID, customers1[i].Name, customers1[i].Salary);
            }

            //note
            // we can only add a object of class customer into the list customer1
            //or we can add a class which inherits from the customer class, because customer1
            // is a collection of its parent class
            //customers1.Add(101); //this is wrong because list is strongly typed.
            SavingsCustomer savingsCustomer = new SavingsCustomer()
            {
                Name = "Archana My Love",
                ID = 104,
                Salary = 123343
            };
            customers1.Add(savingsCustomer);
            //the above line throws no error


            //Add method always add at the end
            //insert helps to insert at any position

            customers1.Insert(0, c3);
            Console.WriteLine();
            foreach (Customer cust in customers1)//foreach is preferable
            {
                Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", cust.ID, cust.Name, cust.Salary);
            }

            Console.WriteLine();
            Console.WriteLine("C3 is present at {0}" ,customers1.IndexOf(c3)); // returns the first matched element index
            Console.WriteLine("C3 is present at {0}", customers1.IndexOf(c3, 1));// returns the first matched element index starting from the specified index
            Console.WriteLine("C3 is present at {0}", customers1.IndexOf(c3, 1, 2));// returns the first matched element index starting from the specified index and ends at the send specified index
            //-1 is returned as the element is not present
            //Console.WriteLine("C3 is present at {0}", customers1.IndexOf(c3, 1, 6));
            //this will through exception as index is not present in the customer1 list
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Starting 2nd lecture of list");
            Console.WriteLine();
            if (customers1.Contains(c3))
                Console.WriteLine("C3 exists in the list");
            else
                Console.WriteLine("C3 exists in the list");

            Console.WriteLine();
            //if (customers1.Exists(customer => customer.Name.StartsWith("Arch")))
            if (customers1.Exists(customer => customer.Name.StartsWith("Z")))
                Console.WriteLine("Arc Named objects exists in the list");
            else
                Console.WriteLine("Arc named objects do not exists in the list");

            Console.WriteLine();
            Console.WriteLine("Display first customer");
            Customer selectedFirstCustomer =  customers1.Find(customer=> customer.Salary > 14000);
            Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", selectedFirstCustomer.ID, selectedFirstCustomer.Name, selectedFirstCustomer.Salary);
            Console.WriteLine("Display last customer");
            Customer selectedLastCustomer = customers1.FindLast(customer => customer.Salary > 14000);
            Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", selectedLastCustomer.ID, selectedLastCustomer.Name, selectedLastCustomer.Salary);
            Console.WriteLine();
            Console.WriteLine("Display all customers");
            List<Customer> allCustomers = customers1.FindAll(customer => customer.Salary > 14000);
            foreach(Customer customer1 in allCustomers)
            {
                Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", customer1.ID, customer1.Name, customer1.Salary);
            }

            Console.WriteLine();
            Console.WriteLine("First Customer index where salary is > 14000 = {0}",customers1.FindIndex(customer=> customer.Salary>14000));
            Console.WriteLine("First Customer index after index {1} where salary is > 14000 = {0}", customers1.FindIndex(1, customer => customer.Salary > 14000), 0);
            Console.WriteLine("First Customer index after index {1} where salary is > 14000 = {0}", customers1.FindIndex(1, 2, customer => customer.Salary > 14000), 0);
            //return -1 as no such customer objects are found.
            Console.WriteLine("Last Customer index after index {1} where salary is > 14000 = {0}", customers1.FindLastIndex(1, customer => customer.Salary > 14000), 0);
            //the overloads have similar use cases
            Console.WriteLine();

            Console.WriteLine("Convert Array to a list");
            List<Customer> myNeewList = customers.ToList();
            foreach (Customer customer1 in myNeewList)
            {
                Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", customer1.ID, customer1.Name, customer1.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("Convert list to Array");
            Customer[] myNeewArray = myNeewList.ToArray();
            foreach (Customer customer1 in myNeewArray)
            {
                Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", customer1.ID, customer1.Name, customer1.Salary);
            }
            Console.WriteLine();
            
            Console.WriteLine("Convert list to Dictionary");
            customers1.Remove(c3); //return bool 
            Dictionary<int, Customer> myNewDiction= customers1.ToDictionary( custom => custom.ID, custom1 => custom1); //custom or custom1 can be same. I just wrote it to differentiate.
            foreach (KeyValuePair<int, Customer> customer1 in myNewDiction)
            {
                Console.WriteLine("Customer ID: {0}, Name: {1}, Salary: {2}", customer1.Value.ID, customer1.Value.Name, customer1.Value.Salary);
            }
            Console.WriteLine();

            Console.ReadKey();




        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    class SavingsCustomer: Customer
    {

    }
}
