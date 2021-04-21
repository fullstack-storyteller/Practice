using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Program_types_1
{
    class Program
    {
        static void Main(/*string[] args*/)
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine("Please enter your First name");
            string fname=Console.ReadLine();
            Console.WriteLine("Please enter your Last name");
            string lname=Console.ReadLine();

            Console.WriteLine("Your name is " + fname + " " + lname);
            Console.WriteLine("Your special name is {0}, {1}", lname, fname);
            Console.WriteLine(@"D:\Educational Videos\KudVenKat");
            //this is how the verbatim literal is used check above
            Console.ReadKey();

        }
    }
}
