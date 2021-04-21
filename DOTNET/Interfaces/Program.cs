using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //interfaces I1 and I2 have same method inside them.
    public interface I1
    {
        void Interface1Method();
    }

    public interface I2
    {
        void Interface1Method();
    }
    
    class ChildClass : I1, I2 /*Below is explicit implementation*/
    {
        
        void I1.Interface1Method() // public access modifier is not valid for explicict implementation
        {
            //throw new NotImplementedException();
            Console.WriteLine("Explicit implementation for I1 Interfacemethod in ChildClass");
        }
        void I2.Interface1Method() // public access modifier is not valid for explicict implementation
        {
            //throw new NotImplementedException();
            Console.WriteLine("Explicit implementation for I2 Interfacemethod in ChildClass");
        }
    }
    class ChildClass1 : I1 //this is called default implementation
    {
        public void Interface1Method()
        {
            Console.WriteLine("Default Implementation in ChildClass1");
        }
    } 

    class ChildClass2: I1, I2 /*Below is explicit and default implementation together*/
    {
        //explicit implementation
        void I1.Interface1Method() // public access modifier is not valid for explicict implementation
        {
            //throw new NotImplementedException();
            Console.WriteLine("explicit implementation for I1 Interfacemethod in ChildClass2");
        }
        public void Interface1Method() // public access modifier is not valid for explicict implementation
        {
            //throw new NotImplementedException();
            Console.WriteLine("default implementation for I2 Interfacemethod in ChildClass2");
        }
    }

    class Program 
    {

        static void Main(string[] args)
        {
            ChildClass1 chc1 = new ChildClass1();
            chc1.Interface1Method();
            Console.WriteLine();

            I1 i1 = new ChildClass();
            i1.Interface1Method();
            Console.WriteLine();

            I2 i2 = new ChildClass();
            i2.Interface1Method();
            Console.WriteLine();
            /*
             * another way to do the above two will be below
             * check it out
             * 
             * **/
            ChildClass chc = new ChildClass();
            ((I1)chc).Interface1Method();
            Console.WriteLine();
            ((I2)chc).Interface1Method();
            Console.WriteLine();

            ChildClass2 chc2 = new ChildClass2();
            chc2.Interface1Method();
            ((I1)chc2).Interface1Method();
            ((I2)chc2).Interface1Method();

            Console.ReadKey();
        }
    }
}
