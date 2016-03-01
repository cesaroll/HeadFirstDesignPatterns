using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH11_Proxy_Remote.Machines;

namespace CH11_Proxy_Remote
{
    class GumballMachineTestDrive
    {
        static int Main(string[] args)
        {
            int count = 0;
            
            if(args.Length < 2)
            {
                Console.WriteLine("Provide name and inventory");
                return 1;
            }

            if(int.TryParse(args[1], out count))
            {
                GumballMachine gumballMachine = new GumballMachine(args[0], count);
                GumballMonitor monitor = new GumballMonitor(gumballMachine);

                monitor.Report();

            }
            else
            {
                Console.WriteLine("INventory should be integer");
                return 1;
            }


            return 0;
        }
    }
}
