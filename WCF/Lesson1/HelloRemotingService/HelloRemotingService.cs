using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHelloRemotingService;

namespace HelloRemotingService
{
    //[Serializable] //to make this class remotable eithermake it serializable or 
    public class HelloRemotingService : MarshalByRefObject, IHelloRemotingService.IHelloRemotingService
    {
        public string GetMessage(string name)
        {
            return "Hello, " + name + "!";
        }
    }
}
