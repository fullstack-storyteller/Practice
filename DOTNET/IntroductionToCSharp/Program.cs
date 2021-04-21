using System;
using X=ClassLibrary1;
using Y=ClassLibrary2;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace IntroductionToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C Sharp training with kudvenkat!");
            Console.WriteLine(X.Sample.Message());
            Console.WriteLine(Y.Sample.Message());
            Console.ReadKey();
        }
    }
}
