using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace NamedServiceContractHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(NamedServiceContractsWCF.NamedServiceContracts)))
            {
                serviceHost.Open();
                Console.WriteLine("Service started @{0}", DateTime.Now);
                Console.ReadKey();
            }
            
        }
    }
}
