using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public class CeilingFan
    {
        private String _location;

        public enum FanSpeed
        {
            HIGH,
            MEDIUM,
            LOW,
            OFF
        }

        public FanSpeed Speed { get; set; }

        public CeilingFan(String location)
        {
            _location = location;
            Speed = FanSpeed.OFF;
        }
        public void High()
        {
            Speed = FanSpeed.HIGH;
            Console.WriteLine("Ceiling Fan in {0} is set to High speed.", _location);
        }

        public void Medium()
        {
            Speed = FanSpeed.MEDIUM;
            Console.WriteLine("Ceiling Fan in {0} is set to Medium speed.", _location);
        }

        public void Low()
        {
            Speed = FanSpeed.LOW;
            Console.WriteLine("Ceiling Fan in {0} is set to Low speed.", _location);
        }

        public void Off()
        {
            Speed = FanSpeed.OFF;
            Console.WriteLine("Ceiling Fan in {0} is set Off.", _location);
        }

        

    }
}
