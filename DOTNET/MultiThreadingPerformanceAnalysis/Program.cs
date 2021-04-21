using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace MultiThreadingPerformanceAnalysis
{
    class Program
    {
        static void OddNumSum()
        {
            double sum = 0;
            for (int i = 0; i < 50000000; i++)
            {
                if (i % 2 == 1)
                    sum += i;
            }
            Console.WriteLine("Sum of odd numbers: {0}", sum);
        }
        static void EvenNumSum()
        {
            double sum = 0;
            for (int i = 0; i < 50000000; i++)
            {
                if(i%2==0)
                    sum += i;
            }
            Console.WriteLine("Sum of even numbers: {0}", sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of processor my PC has = {0}", Environment.ProcessorCount);
            Console.WriteLine("My OS version = {0}", Environment.OSVersion);
            Console.WriteLine("My OS is 64-bit ? {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("My domain name: {0}", Environment.UserDomainName);
            Console.WriteLine("My username: {0}", Environment.UserName); //manis
            Console.WriteLine("My machine name: {0}", Environment.MachineName);
            
            //Console.ReadKey();
            Stopwatch stopwatch = Stopwatch.StartNew();
            EvenNumSum();
            OddNumSum();
            stopwatch.Stop();

            Console.WriteLine("Total milliseconds without multiple threads. {0}", stopwatch.ElapsedMilliseconds);

            Thread T1 = new Thread(EvenNumSum);
            Thread T2 = new Thread(OddNumSum);
            stopwatch = Stopwatch.StartNew();

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            stopwatch.Stop();
            Console.WriteLine("Total milliseconds with multiple threads. {0}", stopwatch.ElapsedMilliseconds);




            //Console.ReadKey();
        }
    }
}
