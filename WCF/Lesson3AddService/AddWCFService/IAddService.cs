using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AddWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAddService
    {
        [OperationContract] //By saying this as operation contract, we are making this method available to all
        int Add(int x, int y); //no need to use public keyword as it is an interface
    }

    [ServiceContract]
    public interface ICompanyPublicService
    {
        [OperationContract] 
        string PublicInformation(); //no need to use public keyword as it is an interface

    }

    [ServiceContract]
    public interface ICompanyPrivateService
    {
        [OperationContract]
        string PrivateInformation(); //no need to use public keyword as it is an interface

    }
}
