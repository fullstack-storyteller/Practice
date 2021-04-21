using System;
using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * the below piece of code is erroroneous below the following reasons
             * 1.   the file could be missing or not accessible
             * 2.   the directory where the file is placed may not even exist or not accessible
             * 
             * Since the error can't be predicted, we state catch block for catching some mostly known exceptions
             * then we add one general exception block*
             * 
             * Ctrl + Alt + E in visual studio gives all the exceptions there are in .Net
             * 
             * most general exception should come at the bottom
             */

            StreamReader sr =null;
            try
            {
                sr = new StreamReader(@"D:\GitHUB\Practice\DOTNET\ExceptionHandling1\MyFiles\Data.txt");
                Console.WriteLine(sr.ReadToEnd());

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.FileName); //the property is availble because we are using the most specific exception / or child class of exception which is therefore specialized
                Console.WriteLine(e.StackTrace);

            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.TargetSite); //the property is availble because we are using the most specific exception / or child class of exception which is therefore specialized
                Console.WriteLine(e.StackTrace);
            }
            //finally we can use the most general kind of exception, if we are not sure what other kind of exception will occure from the code

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            //resources should be released in the finally block. this is a good practice
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    Console.WriteLine("StreamReader released");
                }
            }
            Console.ReadKey();
        }
    }
}
