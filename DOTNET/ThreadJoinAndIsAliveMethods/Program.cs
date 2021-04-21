using System;
using System.Collections.Generic;
using System.Threading;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ThreadJoinAndIsAliveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Main Method Started");
            //Thread T1 = new Thread(() => Thread1Function());
            //T1.Start();

            //Thread T2 = new Thread(() => Thread2Function());
            //T2.Start();

            //Console.WriteLine("Main Method Completed");

            /*
             * This was the output:
             * 
             * Main Method Started
             * Main Method Completed
             * Thread1Function Started
             * Thread2Function Started
             * 
             * As you can see the order is completely messed up.
             * The main thread is unloading the thread1FUnction and thread2function's work on
             * the sub thread and then without waiting for them 
             * moving to the new line of code. This is expected as we are programming in Multithreading
             * 
             * 
             */
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Now lets try to use the Join() method and make the main method wait untill all the sub threads have been completed");

            Console.WriteLine("Main Method Started");
            Thread T1 = new Thread(() => Thread1Function());
            T1.Start();

            Thread T2 = new Thread(() => Thread2Function());
            T2.Start();

            //T1.Join();
            if (T1.Join(1000))
                Console.WriteLine("Thread1Function Completed within 1000 ms");
            else
                Console.WriteLine("Thread1Function has not Completed within 1000 ms");
            Console.WriteLine("Thread1Function Concludes");

            T2.Join();
            Console.WriteLine("Thread2Function Concludes");

            for (int i = 0; i < 19; i++)
            {
                if (T1.IsAlive)
                {
                    Console.WriteLine("Thread1Function is still doing its job");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread1Function Completed.");
                    break;
                }
            }
            Console.WriteLine("Main Method Completed");

            Console.ReadKey();

        }

        static void Thread1Function()
        {
            Console.WriteLine("Thread1Function Started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1Function is about to returned");
        }
        static void Thread2Function()
        {
            Console.WriteLine("Thread2Function Started");
        }
    }
}
