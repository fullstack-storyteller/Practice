using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace AttributesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(5, 10)); // grean swiggly and warning is shown that the method is obsolete
            Console.WriteLine(Calculator.Add(5, 10, 12 ));
            Console.ReadKey();
        }
    }

    class Calculator
    {
        //lets say the initial requirement was to add only two numbers

        //[Obsolete] //instead of simple obsolete attribute, we can customize the method too. Look next line
        [Obsolete("Adding two number is now onsolete. You can add more than two element too.")] // this is showing a custtome message
        //we can take it to another level, to convert the warning into error
        //false -> warning; true->error
        //[Obsolete("Using this method with two parameter will raise an error", true)]
        public static int Add(int x, int y)
        {
            return x + y;
        }
        //some time later the requirement changes, and now the user want to add multiple methods.
        //the old Add definition should still work but the new developers need to be aware of the fact that the old Add method is not absolute
        //thus we can decorate the old Add method with Obsolete Attribute
        public static int Add(params int[] x)
        {
            int sum = 0;
            foreach(int y in x)
            {
                sum += y;
            }
            return sum;
        }
    }
}
