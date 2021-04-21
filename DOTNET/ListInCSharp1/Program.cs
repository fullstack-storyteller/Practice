using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                CustomerType = "Retail Customer",
                ID = 101,
                Name = "Manish Kumar",
                Salary = 12000
            };

            Customer c2 = new Customer()
            {
                CustomerType = "Retail Customer",
                ID = 102,
                Name = "Manisha Kumari",
                Salary = 14000
            };

            Customer c3 = new Customer()
            {
                CustomerType = "Retail Customer",
                ID = 103,
                Name = "Achana Verma",
                Salary = 13000
            };

            Customer c4 = new Customer()
            {
                CustomerType = "Corporate Customer",
                ID = 104,
                Name = "Archana My Love",
                Salary = 16000
            };

            Customer c5 = new Customer()
            {
                CustomerType = "Corporate Customer",
                ID = 105,
                Name = "Tripti Sharma",
                Salary = 10000
            };

            List<Customer> listCustomer = new List<Customer>();
            listCustomer.Add(c1);
            listCustomer.Add(c2);
            listCustomer.Add(c3);

            List<Customer> listCorporateCustomer = new List<Customer>();
            listCorporateCustomer.Add(c4);
            listCorporateCustomer.Add(c5);

            listCustomer.AddRange(listCorporateCustomer);//adding a list
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Type: {3}", c.ID, c.Name, c.Salary, c.CustomerType);
            }
            Console.WriteLine();
            //only the corporate customer using getrange()
            List<Customer> newListCustomers = listCustomer.GetRange(0, 3);//adding a list
            foreach (Customer c in newListCustomers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Type: {3}", c.ID, c.Name, c.Salary, c.CustomerType);
            }
            Console.WriteLine();
            //lets try the insert range function
            listCustomer.InsertRange(0, listCorporateCustomer);
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Type: {3}", c.ID, c.Name, c.Salary, c.CustomerType);
            }
            Console.WriteLine();
            //remove a elemet
            listCustomer.Remove(c4);
            foreach(Customer c in listCustomer)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Type: {3}", c.ID, c.Name, c.Salary, c.CustomerType);
            }
            //remove at
            Console.WriteLine();
            listCustomer.RemoveAt(4);
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Type: {3}", c.ID, c.Name, c.Salary, c.CustomerType);
            }
            Console.WriteLine();

            //remove range
            Console.WriteLine();
            listCustomer.RemoveRange(0, 2);
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Type: {3}", c.ID, c.Name, c.Salary, c.CustomerType);
            }
            Console.WriteLine();

            //remove all
            Console.WriteLine();
            Console.WriteLine("Removed the {0} number of rows",listCustomer.RemoveAll(custo => custo.CustomerType == "Retail Customer"));
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Type: {3}", c.ID, c.Name, c.Salary, c.CustomerType);
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
        public string CustomerType { get; set; }

    }
}
