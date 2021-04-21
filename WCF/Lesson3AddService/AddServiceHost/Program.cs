using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AddServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AddWCFService.AddService)))
            {
                host.Open();
                Console.WriteLine("Service Starte @: {0}",DateTime.Now.ToString());
                Console.ReadKey();
            }

        }
    }
}
