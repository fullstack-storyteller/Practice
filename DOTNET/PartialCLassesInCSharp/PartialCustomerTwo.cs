using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialCLassesInCSharp
{
    public partial class PartialCustomer
    {
        //putting only public methods here
        string message;
        public string GetFullName()
        {
            return this._lastName + ", " + this._firstName;
        }
        //no compilation error observer, even though the private fields are not present.
        //this is the power of pertial classes.

        public string WorkingWithPartialMethods(string noun)
        {
            message = "Hey, "+noun+"! This part is coming from WorkingWithPartialMethods(sting noun)! <br/>";
            PartialMethodToWriteSomething(message);
            return message+"<br/>";

        }
        //working with partial method PartialMethodToWriteSomething
        partial void PartialMethodToWriteSomething(string mymessage)
        {
            message += "And this part comes from the partial method PartialMethodToWriteSomething(string mymessage)";
        }

        


    }
}