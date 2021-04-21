using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Text;
namespace StringsAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = "C#";
            userString += " Video";
            userString += " Tutorials";
            userString += " for";
            userString += " beginner";

            //the above approach will create many orphan string object,
            //i.e. object will still be there in memory but there will be no reference variable
            //for them. These are treated as garbage.
            //They will detoriate your program memory management and performance

            //Use StringBuilder class, when you need to perform heavy string manipulation


            Console.WriteLine(userString);
            StringBuilder userStringBuilder = new StringBuilder("C#");
            userStringBuilder.Append(" Video");
            userStringBuilder.Append(" Tuotorials");
            userStringBuilder.Append(" for");
            userStringBuilder.Append(" begineer");
            Console.WriteLine(userStringBuilder.ToString());


            Console.ReadKey();
        }
    }
}
