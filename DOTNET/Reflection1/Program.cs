using System;
using Customer; //this is the external library / assembly, which we need to test
using System.Reflection; //remember to import this to work with Reflection
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Reflection1
{
    public class Program
    {
        static void Main(string[] args)
        {

            //remember most of important thing in reflection
            //revolves around Type Class from System.Type

            //Type TestClass = typeof(CustomerDetails);
            //Type T = Type.GetType("Customer.CustomerDetails"); // For some reasons, the getType eas not not working for external class library, 
            //So, I'm using the typeof operator to get the type, and it works as charm!!!
            //Type T = typeof(Customer.CustomerDetails); //this is preferred, because it use intellisense and reduces the chance of misspelling
            CustomerDetails cd = new CustomerDetails();
            Type T = cd.GetType(); //this is another way of getting the type of the class

            //get all the properties of the class in question

            Console.WriteLine("Full Name of th Type: {0}",T.FullName);
            Console.WriteLine("Just the Name: {0}", T.Name);
            Console.WriteLine("Just the Namespace: {0}", T.Namespace);

            Console.WriteLine();
            Console.WriteLine("Properties included are below: ");
            PropertyInfo[] properties= T.GetProperties();

            foreach(PropertyInfo pi in properties)
            {
                Console.WriteLine("{0} {1}",pi.PropertyType, pi.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Methods included are below: ");
            MethodInfo[] methodInfos = T.GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine("{0} {1}", methodInfo.ReturnType, methodInfo.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Constructors included are below: ");
            ConstructorInfo[] constructorInfos= T.GetConstructors();
            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine("{0} {1}", constructorInfo.ToString(), constructorInfo.GetHashCode());
            }
            Console.ReadKey();
        }
    }
}
