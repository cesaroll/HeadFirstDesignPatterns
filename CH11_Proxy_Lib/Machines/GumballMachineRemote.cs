using CH11_Proxy_Remote.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_Proxy_Remote.Machines
{
    public abstract class GumballMachineRemote : MarshalByRefObject
    {
        public abstract int GetCount();

        public abstract string GetLocation();

        public abstract State GetState();

        public abstract void SayHello();

    }
}
