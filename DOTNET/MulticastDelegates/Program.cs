using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void SampleDelegate();
    public delegate int SampleDelegateWithReturnType();
    public delegate void SampleDelegateWithOutputParam(out int x);

    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate sd1 = new SampleDelegate(SmapleMethod1);
            SampleDelegate sd2 = new SampleDelegate(SmapleMethod2);
            SampleDelegate sd3 = new SampleDelegate(SmapleMethod3);
            // one way to muticast a delegate is but specifically adding them using + sign
            SampleDelegate sd = sd1 + sd3 + sd2;

            // all the methods to which a delgated is pointing or registered
            // will be added to a list called Delegate Invocation List
            // and will be executed in the first come first execute basis
            sd();
            Console.WriteLine();
            // to unregister a method from a multicast delegate
            sd = sd - sd2;
            sd();
            Console.WriteLine();
            //Another way of registering a method with a delegate

            SampleDelegate sd4 = new SampleDelegate(SmapleMethod1);
            sd4 += SmapleMethod2;
            sd4 += SmapleMethod2;
            sd4 += SmapleMethod3;
            sd4();
            Console.WriteLine();
            sd4 -= SmapleMethod2;
            sd4();
            Console.WriteLine();
            SampleDelegateWithReturnType sr = new SampleDelegateWithReturnType(SmapleMethod4);
            sr += SmapleMethod5;
            Console.WriteLine("Delgate Returned {0}",sr());

            Console.WriteLine();
            SampleDelegateWithOutputParam sdo = new SampleDelegateWithOutputParam(SmapleMethod6);
            sdo += SmapleMethod7;
            int num = 2;
            sdo(out num);
            Console.WriteLine("Output Param from the multicase delegate returned {0}", num);
            Console.ReadKey();
        }
        public static void SmapleMethod1()
        {
            Console.WriteLine("SampleMEthod1 Invoked");
        }
        public static void SmapleMethod2()
        {
            Console.WriteLine("SampleMEthod2 Invoked");
        }
        public static void SmapleMethod3()
        {
            Console.WriteLine("SampleMEthod3 Invoked");
        }
        public static void SmapleMethod6(out int number)
        {
            //Console.WriteLine("SampleMEthod1 Invoked");
            number = 10;

        }
        public static void SmapleMethod7(out int number)
        {
            //Console.WriteLine("SampleMEthod1 Invoked");
            number = 20;
            
        }
        public static int SmapleMethod4()
        {
            //Console.WriteLine("SampleMEthod1 Invoked");
            return 1;
        }
        public static int SmapleMethod5()
        {
            //Console.WriteLine("SampleMEthod1 Invoked");
            return 5;
        }
        
    }
}
