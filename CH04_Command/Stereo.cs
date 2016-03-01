using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is On");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is Off");
        }

        public void SetCD()
        {
            Console.WriteLine("CD playing");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Volume is set to {0}", volume);
        }

    }
}
