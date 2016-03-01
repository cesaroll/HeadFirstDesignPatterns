using CH11_Proxy_Remote.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace CH11_Proxy_Client
{
    public class GumballMonitor
    {
        private GumballMachine GumbalMachine { get; set; }
               
        public GumballMonitor(GumballMachine machine)
        {
            this.GumbalMachine = machine;

            //Create and register the remoting channel
            HttpChannel x_channel = new HttpChannel();
            ChannelServices.RegisterChannel(x_channel, false);

            // local member to initialize the remoting system
            InitRemoteServer();

            Report();
        }

        public void Report()
        {
            GumbalMachine.SayHello();
            Console.WriteLine("Gumball Machine: " + GumbalMachine.GetLocation());
            Console.WriteLine("Current inventory: " + GumbalMachine.GetCount() + " gumballs");
            Console.WriteLine("Current state: " + GumbalMachine.GetState().ToString());
        }


        private void InitRemoteServer()
        {
            RemotingConfiguration.RegisterWellKnownClientType(typeof(GumballMachine), "http://localhost:20172/GumballMachine");
        }

    }
}
