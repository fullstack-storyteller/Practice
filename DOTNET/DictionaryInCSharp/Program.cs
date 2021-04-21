using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lecture 72: Dictionary in c#");
            Customer c1 = new Customer()
            {
                ID  = 101,
                Name = "Archana",
                Salary = 233000.5f
            };

            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "Manish",
                Salary = 200000.5f
            };

            Customer c3 = new Customer()
            {
                ID = 119,
                Name = "Archana Baby",
                Salary = 233666.7f
            };

            Customer c4 = new Customer()
            {
                ID = 119,
                Name = "The tamanah in ODC",
                Salary = 233666.7f
            };

            Dictionary<int, Customer> dictionaryCustomers
                = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(c1.ID, c1);
            dictionaryCustomers.Add(c2.ID, c2);
            dictionaryCustomers.Add(c3.ID, c3);
            //dictionaryCustomers.Add(c4.ID, c4); // this is not allowed because key should be unique and the key 119 is already preent in the dictionary
            //thus we do this
            if (!dictionaryCustomers.ContainsKey(c4.ID)) //before retieving or add a key value pair it is always a good practice to check if the key exists
            {
                dictionaryCustomers.Add(c4.ID, c4);
            }


            Customer c101 = dictionaryCustomers[101];

            if (dictionaryCustomers.ContainsKey(135))
            {
                Customer c135 = dictionaryCustomers[135];
            }

            Console.WriteLine("ID: {0}, Name= {1}, Salary={2}", c101.ID, c101.Name, c101.Salary);
            Console.WriteLine();

            foreach(KeyValuePair<int, Customer> keyValuePair in dictionaryCustomers)
            {
                
                Console.WriteLine("The Key is {0}", keyValuePair.Key);
                Console.WriteLine("ID: {0}, Name= {1}, Salary={2}", keyValuePair.Value.ID, keyValuePair.Value.Name, keyValuePair.Value.Salary);
                Console.WriteLine("-------------------------------------------------------------------");
            }

            //or we can use an implicitly typed variable 'var'
            // we must not encourage to much use of 'var' keyword
            Console.WriteLine();

            foreach (var keyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("ID: {0}, Name= {1}, Salary={2}", keyValuePair.Value.ID, keyValuePair.Value.Name, keyValuePair.Value.Salary);
            }

            Console.ReadKey();

            Console.WriteLine("Lecture 73: Dictionary in c# - continued");

            // how to use trygetvalue method
            Customer cust;
            //int myKey = 101;
            int myKey = 104;
            if (dictionaryCustomers.TryGetValue(myKey, out cust))
            {
                Console.WriteLine("ID: {0}, Name= {1}, Salary={2}", cust.ID, cust.Name, cust.Salary);
            }
            else
                Console.WriteLine("The Key {0} is not found", myKey);

            //how to use count method
            Console.WriteLine();
            //let's use count property
            Console.WriteLine("The total count of Customers using count property is {0}", dictionaryCustomers.Count);
            
            Console.WriteLine(); //link extension method
            Console.WriteLine("The total number of customers using count method is {0}", dictionaryCustomers.Count());
            Console.WriteLine("The total number of customers using count method with predicate is {0}", dictionaryCustomers.Count(keyValuePair => keyValuePair.Value.Salary> 200001));

            Console.WriteLine();
            Console.WriteLine(dictionaryCustomers.Remove(myKey)); //if the key is not present, no exception will happen
            //if removed successfully, true will be returned

            Console.WriteLine();
            dictionaryCustomers.Clear(); // this will remove all the items in the dictionary
            Console.WriteLine("The total count of Customers using count property is {0}", dictionaryCustomers.Count);
            
            Console.WriteLine();

            Console.WriteLine("COnvert an array into dictionary");

            Customer[] Customer_Array = new Customer[3];
            Customer_Array[0] = c1;
            Customer_Array[2] = c3;
            Customer_Array[1] = c2;
            
            foreach (Customer c in Customer_Array)
            {
                Console.WriteLine("ID: {0}, Name= {1}, Salary={2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine();
            Dictionary<int, Customer> MyNewCustomers = Customer_Array.ToDictionary(customer => customer.ID, customer => customer);
            
            Console.WriteLine("Dictionary Displayed");
            foreach (KeyValuePair<int, Customer> keyValuePair in MyNewCustomers)
            {
                Console.WriteLine("ID: {0}, Name= {1}, Salary={2}", keyValuePair.Value.ID, keyValuePair.Value.Name, keyValuePair.Value.Salary);
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Convert a list into dictionary");

            List< Customer> Customer_List = new List<Customer>();
            Customer_List.Add(c1);
            Customer_List.Add(c2);
            Customer_List.Add(c3);

            foreach (Customer c in Customer_List)
            {
                Console.WriteLine("ID: {0}, Name= {1}, Salary={2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine();
            Dictionary<int, Customer> MyNewCustomersFromList = Customer_List.ToDictionary(c=> c.ID, custu=> custu);// c is coming from the list.
            //as c i.e. customer is repeating part of customer list.


            Console.WriteLine("Dictionary Displayed");
            foreach (KeyValuePair<int, Customer> keyValuePair in MyNewCustomers)
            {
                Console.WriteLine("ID: {0}, Name= {1}, Salary={2}", keyValuePair.Value.ID, keyValuePair.Value.Name, keyValuePair.Value.Salary);
            }
            Console.ReadKey();
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
}
