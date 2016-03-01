using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door Openning");
            
            Console.WriteLine("Garage Door Open");
            
        }

        public void Down()
        {
            Console.WriteLine("Garage Door Down");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door Stop");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Light On");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage Light Off");
        }
    }
}
