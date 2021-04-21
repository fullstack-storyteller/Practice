using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
//using System.Text;
//using System.Threading.Tasks;


    // this is a very good program.
namespace CallbackMultithreading2
{
    public delegate void SumOfNumbersCallback(int SumOfNumbers);
    class Program
    {
        static void PrintSumOfNumbers(int x)
        {
            Console.WriteLine("The sum is {0}", x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int a = int.Parse(Console.ReadLine());

            SumOfNumbersCallback sumOfNumbersCallback = new SumOfNumbersCallback(PrintSumOfNumbers);
            Number number = new Number(a, sumOfNumbersCallback);
            Thread T = new Thread(() => number.PrintNumbers());
            T.Start();

            Console.ReadKey();
        }
    }

    class Number
    {
        int _target;
        SumOfNumbersCallback _sumOfNumbersCallbackMethod;

        public Number(int target, SumOfNumbersCallback sumOfNumbersCallbackMethod)
        {
            this._target = target;
            this._sumOfNumbersCallbackMethod = sumOfNumbersCallbackMethod;
        }

        public void PrintNumbers()
        {
            int sum = 0;
            for(int i =0; i<= this._target; i++)
            {
                sum += i;
            }
            if (this._sumOfNumbersCallbackMethod != null)
                this._sumOfNumbersCallbackMethod(sum);
        }
    }
}
