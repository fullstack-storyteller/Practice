using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace ThreadStartDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread start delegate");
            // a thread will always require a delegate. Remember this
            Thread T = new Thread(Number.PrintNumbers); //.net framework automatically created a delegate for us in this case
            T.Start();
            T.Join(); //this will help allow the main thread to wait for Thread T to finish then it will proceed ahead. Else T may not finish and T1 begin, resulting in inconsistent result.
            Console.WriteLine();

            Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers)); // we are explicitly creating a delegate, i.e. thread start delegate
            T1.Start();
            T1.Join(5000);

            Console.WriteLine();
            //using a delegate keyword
            Thread T2 = new Thread(delegate () { Number.PrintNumbers(); });
            T2.Start();
            T2.Join();
            Console.WriteLine();

            // using a lambda expression
            Thread T3 = new Thread(() => Number.PrintNumbers());
            T3.Start();
            //Use thread start only when you don't need to supply any parameter to the  thread method.
            T3.Join();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Parameterized Threadstart delegate");
            Console.WriteLine("Please enter the target number");
            string myNum = Console.ReadLine();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Number.PrintNumberOfArbitraryLength);
            Thread T4 = new Thread(parameterizedThreadStart);
            //use parameterized thread start delegate if you need to pass some data to the thread method

            T4.Start(myNum); //it is although not advisable, because the start expects a object, which is not type safe
            //hence we should discourage usage of parameterized thread start delegates

            T4.Join();
            Console.WriteLine();
            //T4.Start("Manish");

            //we do not explicitly have to define a parameterised thread start delegate. We can simplly do it like below
            Thread T5 = new Thread(Number.PrintNumberOfArbitraryLength);
            // the compiler converts the above line into the below
            //Thread T5 = new Thread( new ParameterizedThreadStart( Number.PrintNumberOfArbitraryLength));
            T5.Start(myNum + 1);
            T5.Join();
            Console.ReadKey();

            //since we are losing the ability to pass data to a thread function in a type safe manner using a prameterized thread start delegate.
            //let's see what else .net has to offer to fix this.

            Console.WriteLine();
            Console.WriteLine("Passing the data to thread in a type safe manner");

            Number number = new Number(15); //passed the data to the thread function from the constructor itself
            Thread t6 = new Thread(number.PrintNumbersInputFromConstructor); //called the thread
            t6.Start();
            t6.Join();
            Console.ReadKey();


        }
    }

    class Number
    {
        int myTarget;
        public Number(int x)
        {
            myTarget = x;
        }
        public static void PrintNumbers()
        {
            for (int i = 0; i < 20; i++)
                Console.WriteLine(i + 1);
        }

        public static void PrintNumberOfArbitraryLength(object target) //initially we gave int as input. but since parameterised delegate can take in only Object
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
                for (int i = 0; i < number; i++)
                    Console.WriteLine(i + 1);
            else
                Console.WriteLine("Invalid input given to PrintNumberOfArbitraryLength");
        }

        public void PrintNumbersInputFromConstructor()
        {
            for (int i = 0; i < myTarget; i++)
                Console.WriteLine(i + 1);
        }
    }
}
