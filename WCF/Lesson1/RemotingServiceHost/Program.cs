using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting; //needed to host the remoting service
using System.Runtime.Remoting.Channels;// for channel
using System.Runtime.Remoting.Channels.Tcp; //for tcp

namespace RemotingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloRemotingService.HelloRemotingService remotingService =
                new HelloRemotingService.HelloRemotingService();
            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService.HelloRemotingService)
                , "GetMessage", WellKnownObjectMode.Singleton);
            Console.WriteLine("Remoting Service Start @: {0}", DateTime.Now);
            Console.ReadKey();
        }
    }
}
