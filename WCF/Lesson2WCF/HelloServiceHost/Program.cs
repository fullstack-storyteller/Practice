using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost serviceHost = new ServiceHost(typeof(HelloService.HelloServiceWCF)))
            {
                serviceHost.Open();
                Console.WriteLine("WCF Service Host has started @ {0}", DateTime.Now);
                Console.ReadKey();

            }
        }
    }
}
