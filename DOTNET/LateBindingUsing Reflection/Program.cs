using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System.Reflection;

namespace LateBindingUsing_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //We perform late binding when we don't know the class details compile time.
            //99% of time, we only perform early bind i.e. we know the class details and can instantiate it using new keyword

            //for this example, let us assume that the we don't know anything about the Customer Class

            //Now, if the class had been external we would go ahead and use, the actual class name with Name space, but since we
            //taking the  class from the current program assembly itself, we will go as belo:

            Assembly executingAssembly = Assembly.GetExecutingAssembly(); //get the current assembly
            
            //Got the Type of Customer from current executing Assembly
            Type LateBindingCustomerClass=executingAssembly.GetType("LateBindingUsing_Reflection.Customer");

            //let's create an instance of this dynamically generate class
            Object CustomerInstance = Activator.CreateInstance(LateBindingCustomerClass,"Manish", "Kumar");
            //Note, since require an constructor with two parameters, in this case, the values, "Manish", "Kumar"

            //Let's get the method from the class
            MethodInfo GetFullNameDynamic = LateBindingCustomerClass.GetMethod("GetFullName"); //the method name you can getusing reflection. Refer the Reflection Demo

            //We don't need parameter for this method.
            //otherwise we need to create the variables to hold the Parameters

            Console.WriteLine( (string)GetFullNameDynamic.Invoke(CustomerInstance, null)); // we need the instance of the class and since the method doesn't take any parameter, we supply null
            //Note: Type Casting the result of GetFullNameDynamic is a string, so we typecast.

            Console.ReadKey();









        }
    }
}
