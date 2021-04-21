using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In this program, we will discuss the fact sometime how we are 
             * abusing the exception Handling.
             * It is a goood practice not to do that.*
             */
            //try
            //{
            //    Console.WriteLine("Please enter the numerator");
            //    int Numerator = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Please enter the Denominator");
            //    int Denomenator = Convert.ToInt32(Console.ReadLine());
            //    float Result = Numerator / Denomenator;
            //    Console.WriteLine("Result = {0}", Result);
            //}
            //catch(FormatException fe)
            //{
            //    Console.WriteLine("Please only enter number");
            //}
            //catch(OverflowException oe)
            //{
            //    Console.WriteLine("only number between {0} and {1} are allowed", int.MinValue, int.MaxValue);
            //}
            //catch(DivideByZeroException de)
            //{
            //    Console.WriteLine("Dividing by Zero is not allowed. Denominator can't be zero.");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Here is how it should be implemented /handling the exception handling abuse.
            Console.WriteLine("Please enter the numerator");
            int Numerator;
            bool isNumneratorConverted= int.TryParse(Console.ReadLine(), out Numerator);

            if (isNumneratorConverted)
            {
                Console.WriteLine("Please enter the Denominator");
                int Denominator;
                bool IsDenominatorConverted = int.TryParse(Console.ReadLine(), out Denominator);
                
                if (isNumneratorConverted && IsDenominatorConverted && Denominator != 0)
                {
                    Console.WriteLine("Result = {0}", Numerator / Denominator);
                }
                else
                {
                    if (Denominator == 0)
                    {
                        Console.WriteLine("The Denominator can't be Zero");
                    }
                    else
                    {
                        Console.WriteLine("Denominator Should be a valid number between {0} and {1}.", int.MinValue, int.MaxValue);
                    }
                }

            }
            else
                Console.WriteLine("Numerator Should be a valid number between {0} and {1}", int.MinValue, int.MaxValue);

            Console.ReadKey();

        }
    }
}

