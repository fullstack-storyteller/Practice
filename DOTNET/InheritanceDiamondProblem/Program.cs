using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDiamondProblem
{
    interface IA
    {
        void PrintA();
    }
    interface IB
    {
        void PrintB();
    }

    class A : IA
    {
        public void PrintA()
        {
            Console.WriteLine("Implemented PrintA");
        }
        
    }

    class B : IB
    {
        public void PrintB()
        {
            Console.WriteLine("Implemented PrintB");
        }

    }

    /*
     * 
     * If we need to solve the diamond problem here, i.e. the problem caused by a class inheriting multiple class, which is forbidden in .net BTW
     * then instead of class AB inheriting from clas A and Class B , we can inherit the respective interface.
     * this is because multiple interface inheritance is allowed in C#
     * 
     * **/
    class AB : IA, IB
    {
        public void PrintA()
        {
            (new A()).PrintA();
        }

        public void PrintB()
        {
            (new B()).PrintB();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.PrintA();
            ab.PrintB();
            Console.ReadKey();
        }
    }
}
