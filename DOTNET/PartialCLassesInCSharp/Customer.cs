using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialCLassesInCSharp
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;

        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }

        public string  GetFullName()
        {
            return this._lastName + ", " + this._firstName;
        }
    }
}