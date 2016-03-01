using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH11_Proxy_Remote.Machines;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;


namespace CH11_Proxy_Remote
{
    class GumballMachineTestDrive
    {
        static int Main(string[] args)
        {
            //Create and register the channel
            HttpChannel x_channel = new HttpChannel(20172);
            ChannelServices.RegisterChannel(x_channel, false);

            //Register the Server for Remoting
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(GumballMachine), "GumballMachine", WellKnownObjectMode.Singleton);

            //RemotingConfiguration.RegisterActivatedServiceType()

            Console.WriteLine("Press return to exit.");
            Console.ReadLine();

            return 0;
        }
    }
}
