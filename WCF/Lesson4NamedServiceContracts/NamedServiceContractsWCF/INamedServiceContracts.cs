using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NamedServiceContractsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INamedServiceContracts" in both code and config file together.
    [ServiceContract(Name ="INamedServiceContracts" )]
    //public interface INamedServiceContracts <- this was changed later 
    public interface INamedServiceContractsChanged
    {
        //[OperationContract]
        //void DoWork();
        [OperationContract(Name = "SayHello")]
        string SayHelloHakkaNoodles(string name);
    }
}
