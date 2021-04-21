using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Threading;
//let's find out which Aproach is good
using System.Diagnostics;

namespace SharedResouceHandlingInThreads3
{
    class Program
    {
        static int Total = 0;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            //AddToMillion();
            //AddToMillion();
            //AddToMillion();
            ////executing in a linear way using only main thread. No problems the results will be consistent

            // let's break this and see, the results
            Thread T1 = new Thread(() => AddToMillion());
            T1.Start(); //started T1, addition ongoing on Total
            Thread T2 = new Thread(() => AddToMillion());
            T2.Start(); //started T2, addition ongoing on Total, but don't know, if T1 still running
            Thread T3 = new Thread(() => AddToMillion());
            T3.Start(); //started T3, addition ongoing on Total, but don't know, if T2, and T1 still running
                        //thus, it will certainly lead to incorrect result. there is no sync between the threads.

            //we can think of adding join here, but that also doesn't gaurantee that addition will be consistent
            T1.Join(); T2.Join(); T3.Join();
            //ran it from vs command prompt, the addition is certainly not consistent
            stopwatch.Stop();
            Console.WriteLine("Total = {0}", Total);
            //Console.WriteLine("Time Taken in Ticks= {0} in {1}", stopwatch.ElapsedTicks, "Approach 1");
            //Console.WriteLine("Time Taken in Ticks= {0} in {1}", stopwatch.ElapsedTicks, "Approach 2");
            Console.WriteLine("Time Taken in Ticks= {0} in {1}", stopwatch.ElapsedTicks, "Approach 3");
            //Console.ReadKey();
        }

        static object _lock = new object(); // this lock we will use for Approach 1 and Approach 3.
        //this should be static.

        static void AddToMillion() //this is increment a variable total to a million.
        {

            //We need to come up with a way to ensure, the share resource Total is not getting inconsistent updates

            //Approach 1: lock the shared resource under the current thread which is executing it.
            //            this will make sure the other threads have to wait to gain access to it.

            //Approach 2: use Interlocked.Increment method to ensure locked increment
                //Approach 2 is more performant, but its Interlocked.Increment can only work with simple 
                //arithmatic operations or reading.

            //Approach 3: Use of Monitor class.
                //remember this option is similar to the Approach 1, but Monitor class provide more control 
                //for the developers, with help of it wide range of methods, like TryEnter, Pulse() and many more.



            for (int i=0; i<1000000; i++)
            {
                ////Aproach 1
                //lock (_lock) //locked the shared resource
                //{
                //    Total++;
                //}

                ////Approach 2
                //Interlocked.Increment(ref Total);

                ////Approach 3
                bool lockTaken = false;
                Monitor.Enter(_lock, ref lockTaken);
                try
                {
                    Total++;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (lockTaken)
                    {
                        Monitor.Exit(_lock);
                    }
                }
            }
        }
    }
}
