using CH11_Proxy_Remote.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_Proxy_Remote
{
    public class GumballMonitor
    {
        private GumballMachine GumbalMachine { get; set; }

        public GumballMonitor(GumballMachine machine)
        {
            this.GumbalMachine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + GumbalMachine.Location);
            Console.WriteLine("Current inventory: " + GumbalMachine.Count + " gumballs");
            Console.WriteLine("Current state: " + GumbalMachine.State.ToString());
        }
    }
}
