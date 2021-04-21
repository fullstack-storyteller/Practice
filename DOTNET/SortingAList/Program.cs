using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace SortingAList
{
    class Program
    {
        static void PrintNumbers<T>(List<T > x)
        {
            foreach (T a in x)
                Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6};
            Console.WriteLine("Numbers before sorting ");
            PrintNumbers(numbers);
            numbers.Sort(); //ascending order
            Console.WriteLine("Numbers after sorting ");
            PrintNumbers(numbers);
            Console.WriteLine("Numbers in decscending order ");
            numbers.Reverse(); //descending order
            PrintNumbers(numbers);
            Console.WriteLine();
            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C"};
            Console.WriteLine("strings before sorting ");
            PrintNumbers(alphabets);
            alphabets.Sort(); //ascending order
            Console.WriteLine("strings after sorting ");
            PrintNumbers(alphabets);
            Console.WriteLine("strings in decscending order ");
            alphabets.Reverse(); //descending order
            PrintNumbers(alphabets);
            // .Net Frameworks knows how to sort the list of simple types, because
            // these simple type already provide the implementation of CompareTo() (interface IComparable) method
            // CompareTo() method returns an integer, and the meaning of the return value is hsown below.
            
            //Greater than Zero - The current instance is greater than the object being compared with.
            //Less Than Zero - The current instance is less than the object being compared with.
            //is Zero - The Current instance is equal to the object it is being compared with.


            //this is how we sort the simplet types,
            //lets sh=ort the complex types

            Customer c1 = new Customer() { ID = 101, Name = "Archana", Salary=12339};
            Customer c2 = new Customer() { ID = 102, Name = "Archana1", Salary = 12000 };
            Customer c3 = new Customer() { ID = 103, Name = "Archana2", Salary = 13443 };
            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            Console.WriteLine();
            Console.WriteLine("Before sorting customers");
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary:{2}", c.ID, c.Name, c.Salary);
            }
            customers.Sort();

            Console.WriteLine();
            Console.WriteLine("After sorting customers");
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary:{2}", c.ID, c.Name, c.Salary);
            }

            Console.WriteLine();
            Console.WriteLine("Reverse sorting customers");
            customers.Reverse();
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary:{2}", c.ID, c.Name, c.Salary);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Sorting using IComparer class
            /*
             * If you prefer not to use the sort
             * functionailty provided by the class, then you can provide your own 
             * implementation by implementing ICOmparer interface.
             * 
             * if we need to sort the customers using Name not salary and we don't want to 
             * touch the Customer class
             * *
             
             */
            List<Customer> anotherCustomerList = customers;
            anotherCustomerList.Sort(new SortByName());//called the objectof the Customer comparer class SortByName
            
            Console.WriteLine("Sorted using the IComparer");
            foreach (Customer c in anotherCustomerList)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary:{2}", c.ID, c.Name, c.Salary);
            }

            Console.ReadKey();
            Console.WriteLine();

            //Comparison Delegate use in sorting
            Comparison<Customer> customerComparison = new Comparison<Customer>(CompareCustomer);
            Console.WriteLine("before sorting using the Comparison delegate based on ID");
            foreach (Customer c in anotherCustomerList)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary:{2}", c.ID, c.Name, c.Salary);
            }
            anotherCustomerList.Sort(customerComparison);
            anotherCustomerList.Reverse();
            Console.WriteLine("after sorting using the Comparison delegate based on ID, then reversing it for output");
            foreach (Customer c in anotherCustomerList)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary:{2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine();

            Console.WriteLine("after sorting using the Comparison delegate based on ID, again using Lambda expression");
            anotherCustomerList.Sort((x, y) => x.ID.CompareTo(y.ID));
            foreach (Customer c in anotherCustomerList)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary:{2}", c.ID, c.Name, c.Salary);
            }


            Console.ReadKey();
        }
        public static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }

    }

    class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name); //compareTo implementation is given already for string 's IComparable interface
        }
    }
    class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other) //we need to provide implementation of this method from IComparable interface.
        {
            /*
             * The below six line of code is good, when we are implementing
             * an existing interface. there is no problem here
             * 
             * but, we see that we already have int type which has implemented 
             * compareto method from Icomparable interface.
             * 
             * Thus lets increase the degree of code reuse
             * */
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else
            //    return 0;
            return this.Salary.CompareTo(other.Salary); //just a one line code
        }
    }
}
