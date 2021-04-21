using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NamedServiceContractsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NamedServiceContracts" in both code and config file together.
    //public class NamedServiceContracts : INamedServiceContractsChanged
    public class NamedServiceContracts : INamedServiceContractsChanged
    {
        //public void DoWork()
        //{
        //}

        public string SayHello(string name)
        {
            return string.Format("Hello, {0}", name);
        }

        public string SayHelloHakkaNoodles(string name)
        {
            return string.Format("Hello, {0}", name);
        }
    }
}
