using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloServiceWCF" in both code and config file together.
    [ServiceContract]//by decorating it by serviceContract, the interface become WCF service
    public interface IHelloServiceWCF
    {
        [OperationContract] //by decorating it like OperationContract this will be availble to the client
        string GetMessage(string name);
    }
}
