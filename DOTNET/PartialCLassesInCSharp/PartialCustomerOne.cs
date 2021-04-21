using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialCLassesInCSharp
{
    public partial class PartialCustomer
    {
        //putting only private field and public properties here

        private string _firstName;
        private string _lastName;

        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }

        //Sample Partial Method, this is how we declare it.
        partial void PartialMethodToWriteSomething(string msg );
        //Note, partial methods shold have 'void ' return type
        // a partial method can not have access modifiers
        partial void UnImplementedPartialMethod();
        //we can have an unimplemented partial method.
        //this doesn't cause any issue with the prgram. Implementation of a partial method is optional
        //Declaration is mandatory for partial method

    }
}