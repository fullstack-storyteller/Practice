using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace QueueInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer() { Gender = "Male", ID = 101, Name="Manish"};
            Customer c4 = new Customer() { Gender = "Female", ID = 102, Name = "Manisha" };
            Customer c3 = new Customer() { Gender = "Male", ID = 103, Name = "Ramesh" };
            Customer c2 = new Customer() { Gender = "Female", ID = 104, Name = "Akila" };
            Customer c5 = new Customer() { Gender = "Male", ID = 105, Name = "Archana" };

            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(c1);
            queueCustomers.Enqueue(c4);
            queueCustomers.Enqueue(c3);
            queueCustomers.Enqueue(c2);
            queueCustomers.Enqueue(c5); // Add element in queue
            Console.WriteLine();

            PrintQueue(queueCustomers);
            Console.WriteLine();

            Console.WriteLine("Total Number of Element right now {0}", queueCustomers.Count);
            Console.WriteLine("Total Number of Male Element right now {0}", queueCustomers.Count(c => c.Gender == "Male"));
            
            queueCustomers.Dequeue();
            Console.WriteLine("Total Number of Element right now {0}", queueCustomers.Count);
            Console.WriteLine();
            Console.WriteLine("Does it Contains c3: {0}", queueCustomers.Contains(c3));
            Console.WriteLine();
            Customer c_= queueCustomers.Peek();
            Console.WriteLine("Item at the beginning of the queue ID = {0}, Name = {1}, Gender = {2} ", c_.ID, c_.Name, c_.Gender );
            Console.WriteLine();
            //remeber queue follows first in first out logic

            Console.ReadKey();
        }
        static void  PrintQueue(Queue <Customer> cq)
        {
            foreach (Customer c in cq)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}", c.ID, c.Name, c.Gender);
            }
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
    }
}
