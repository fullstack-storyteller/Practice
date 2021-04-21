using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TeacherServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Lesson4WCFDataContractsAndMembers.TeacherService)))
            {
                host.Open();
                Console.WriteLine("Teacher Service Started at {0}.", DateTime.Now.ToString());
                Console.ReadKey();
            }
        }
    }
}
