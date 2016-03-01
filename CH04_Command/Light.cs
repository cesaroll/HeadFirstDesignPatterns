using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public class Light
    {
        private String _name;
        public Light(String name)
        {
            _name = name;
        }
        public void On()
        {
            Console.WriteLine("{0} Light is On", _name);
        }
        public void Off()
        {
            Console.WriteLine("{0} Light is Off", _name);
        }
    }
}
