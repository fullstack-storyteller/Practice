using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace StackInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() { Gender = "Male", Name = "Manish", ID = 101 };
            Customer c4 = new Customer() { Gender = "Female", Name = "Manisha", ID = 102 };
            Customer c3 = new Customer() { Gender = "Female", Name = "Akila", ID = 103 };
            Customer c2 = new Customer() { Gender = "Male", Name = "Poonam", ID = 104 };
            Customer c5 = new Customer() { Gender = "Female", Name = "Archana", ID = 105 };

            Stack<Customer> StackCustomers = new Stack<Customer>();
            StackCustomers.Push(c1);
            StackCustomers.Push(c2);
            StackCustomers.Push(c4);
            StackCustomers.Push(c3);
            StackCustomers.Push(c5);

            Console.WriteLine("Total Number of element = {0}", StackCustomers.Count);
            Console.WriteLine("Total Number of element = {0}", StackCustomers.Count(c => c.Gender =="Female"));
            Console.WriteLine();
            Customer c_ = StackCustomers.Peek();
            Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}", c_.ID, c_.Name, c_.Gender);

            Console.WriteLine();
            PrintStack(StackCustomers);

            Console.WriteLine();
            StackCustomers.Pop();
            PrintStack(StackCustomers);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void PrintStack(Stack<Customer> sc)
        {
            foreach(Customer c in sc)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}",c.ID, c.Name, c.Gender);
            }
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

}
