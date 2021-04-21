using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    class Program
    {
        static void Main() {

            int i = 10;
            float f = i;

            // the above requires not explicit conversion
            // a smaller datatype can be converted into a larger datatype implicitly

            //float k = 123.5f;
            //int x = k;
            //the above is not allowed , so we need to use the explicit conversion
            float k = 123.5f;
            int x = (int)k; //(type )->this is typecasting operator
            Console.WriteLine("float k = {0} converted to int x ={1}", k, x);
            // upon seeing the output you might see that decimal value in float k has been lost
            //that's what happens when the explicit conversion takes place
            /*
             if the float is containing a value much larger than that of the int
             then, the type casting operator will throw any error instead it will give some 
             garbage value i.e. the smallest signed integer value

            if you want a exception to be throw when conversion does not happen properly, 
            use the below
             */


            float m = 1231231213123123123123123.5f;
            int p = (int)m;
            Console.WriteLine("float m = {0} converted to int p ={1}", m, p);
            //output is -2147483648, this means even though conversion is 
            //not successfull the result is coming somehow. this is not good


            //int y = Convert.ToInt32(m);// convert.toInt32 converts from object type to int or any desired type
            //int y = int.Parse(m.ToString()); //parse tries to convert from string to desired datatype
            //this cause overflow exception as the integral part of float can't be contained in integer y
            //Console.WriteLine("float m = {0} converted to int y ={1}", m, y);
            //the above is somewhat good practice. But we can make it better


            //Use of tryparse ,method
            //remember tryparse willwork only on string
            int result = 0;
            
            bool converted = int.TryParse("1231231213123123123123123.5", out result);
            //tryparse tries to convert from string to desired datatype
            //it returns boolean
            //and a output parameterwhich contains the value of converted data if the data conversion is successfull.
            Console.WriteLine("Converted Value = {0}", converted ? result.ToString() : "Can't convert");


            Console.ReadKey();
        }
        
        
        

        


        

        



        }
    }

