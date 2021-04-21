using System;
using System.IO;
using System.Runtime.Serialization;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CustomExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in");
            }
            catch(UserAlreadyLoggedInException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadKey();
                
        }

    }

    /*
     * if you want to move one exception class of or any class, the class should be serializable
     * decorate your exception or class with [Serializable]
     * **/
    [Serializable]
    public class UserAlreadyLoggedInException: Exception
    {
        //overloaded constructor for this exception
        public UserAlreadyLoggedInException(): base()
        {

        }
        public UserAlreadyLoggedInException(string message): base(message)
        {
            
        }
        //now our custom exception class can handle inner exceptions too
        public UserAlreadyLoggedInException(string message, Exception innerException):
            base(message, innerException)
        {

        }

        //to make the object / class / exception seriallize it.
        // give a serialized constructor
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }


    }
}
