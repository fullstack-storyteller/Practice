using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NullableTypesandParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 11;
            bool isNumber10 = Number == 10 ? true : false;
            Console.WriteLine("the number = 10? {0}", isNumber10);
            Console.ReadKey();

            bool? isMinor=null;
            //let's suppose the form is submitted and isMinor is supposed to have the below values.
            /*
             1. Yes, if the user is minor
             2. No, if the user in major
             3. Null, if the user chose not to provide this information

            this scenario can't be handled through non nullable value type bool, as it allows only three values
            true and false not null
            so we make boolean a  nullable type bool?
             */
            switch (isMinor)
            {
                case true: Console.WriteLine("Yes, it is a minor.");
                    break;
                case false: Console.WriteLine("NO, it is not a minor.");
                    break;
                case null:
                    Console.WriteLine("value not provided by the user");
                    break;
                default: Console.WriteLine("This is the default case");
                    break;
            }

            /*if you want to retrive the non nullable value from the nullable type use the .Value property of nullable types*/
            int? ticket = 100;
            int AvailableTickets = ticket ?? 0;
            //note the above AvailableTickets value is not nullable but it is assigned the value of a nullable type using null colasce operation
            Console.WriteLine("Available ticket using Colsace operator = {0}", AvailableTickets);
            // lets try using the .Value property
            Console.WriteLine("Given Tickets are using ticket.Value = {0}", ticket.Value);
            //remember the tickets.Value is returning non nullable type int
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
