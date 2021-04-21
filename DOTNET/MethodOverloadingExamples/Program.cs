using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace MethodOverloadingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20);
            Add(10, 20, 30, 40);
            Console.WriteLine();
            //calling without parameter
            AddWithoutParams(10, 20, null); //only two arguments can't be passed the third parameter is not params keyword. So we supply null
            AddWithoutParams(10, 20, new int[] { 30, 40 });
            Console.WriteLine();
            AddWithoutParamsButNull(10, 23);
            AddWithoutParamsButNull(10, 20, new int[] { 30, 40 });
            //optional parameters must appear after all required parameters
            //AddWithoutParamsButNull(10,  new int[] { 30, 40 }, 20); //that's this will throw an error.

            Console.WriteLine();
            AddWithNamedParameters(10, 30, 40);
            AddWithNamedParameters(10, 30);
            AddWithNamedParameters(x : 3, z : 9); //named parameter allows us to not send value of a few parameter. like here we asre not sending the value for y

            //using optional atributte, which is present in System.Runtime.InteropsServices
            Console.WriteLine();
            AddWithOptionalAttributefromInterops(10, 20);
            AddWithOptionalAttributefromInterops(10, 20 , new int[] { 12, 34, 68});
            Console.ReadKey();
        }
        public static void Add(int x, int y, params int[] list) //using params helps make the parameter optional
            //params keyword must be the last parameter in a method definition.
        {
            int result = x + y;
            if (list != null)
            {
                foreach (int i in list)
                    result += i;

            }
            Console.WriteLine("Sum is {0}", result);
        }
        public static void AddWithoutParams(int x, int y,  int[] list) //using params helps make the parameter optional
                                                                //params keyword must be the last parameter in a method definition.
        {
            int result = x + y;
            if (list != null)
            {
                foreach (int i in list)
                    result += i;

            }
            Console.WriteLine("Sum is {0}", result);
        }

        public static void AddWithoutParamsButNull(int x, int y,  int[] list =null)  // made the default value of pr

        {
            int result = x + y;
            if (list != null)
            {
                foreach (int i in list)
                    result += i;

            }
            Console.WriteLine("Sum is {0}", result);

        }

        public static void AddWithNamedParameters(int x =1, int y=3, int z =4)
                                                                     
        {
            
            
            Console.WriteLine("Sum is {0}", (x + y + z));
        }

        //public static void AddWithOptionalAttributefromInterops(int x, int y, [Optional] int[] list )  
            //or we can writing with optional attribute
        public static void AddWithOptionalAttributefromInterops(int x, int y, [OptionalAttribute] int[] list)  

        {
            int result = x + y;
            if (list != null)
            {
                foreach (int i in list)
                    result += i;

            }
            Console.WriteLine("Sum is {0}", result);

        }

    }
}
