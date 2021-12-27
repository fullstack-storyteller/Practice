using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVSNew
{
    class BaseClass
    {
        public void method1()
        {
            Console.WriteLine("Base Class - method1");
        }
        public virtual void method2()
        {
            Console.WriteLine("Base Class - method2");
        }
    }
    class ChildClass:BaseClass
    {
        public override void method2() //without using the new keyword we get a swiggly
        {
            Console.WriteLine("Child Class - method2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            BaseClass bc = new BaseClass();
            ChildClass cc = new ChildClass();
            BaseClass bcCc = new ChildClass();
            bc.method1();
            bc.method2();
            cc.method1();
            cc.method2();
            bcCc.method1();
            bcCc.method2();
            

            Console.ReadKey();
        }
    }
}
