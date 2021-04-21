using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Calculator.AreEqual(10, 10))
            //if (Calculator.AreEqual(10, "10")) //this will throw a compilation error and 10 and "10" come 
            //under object by now the parameter is strongly typed.
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Unequal");
            }

            Console.ReadKey();
        }

    }
    //class Calculator<GenericType> //this is correct! and used it when you want to make a class generic.
    class Calculator
    {
        /*
         * This method with object as parameters will work as expected for all the types in C#,
         * but, it causes too much boxing and unboxing  and will degrade the performanace
         * *
         */
        //public static bool AreEqual(object i, object j)
        //{

        //    return i == j;
        //}

        //this method may or may not return result as we are expecting.
        //this is not a strongly typed method
        /*
         *
         *Thus we use generics to correct this issue*
         */

        //making the below method strongly types
        //GenericType is anything, note this is not a keyword in C#, it is just something I just cameup
        public static bool AreEqual<GenericType>(GenericType  i, GenericType j)
        {

            return i.Equals(j);
        }

        //you can also make a class a generic type by using <GenericType> alongside the class name
        //No boxing or unboxing happens when we use a Generic
    }
}
