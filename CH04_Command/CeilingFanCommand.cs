using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public abstract class CeilingFanCommand : ICommand
    {
        protected CeilingFan _ceilingFan;
        private CeilingFan.FanSpeed _prevSpeed;
                
        protected CeilingFanCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            ExecuteCommand();
        }

        protected abstract void ExecuteCommand();
        

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFan.FanSpeed.HIGH:
                    _ceilingFan.High();
                    break;
                case CeilingFan.FanSpeed.MEDIUM:
                    _ceilingFan.Medium();
                    break;
                case CeilingFan.FanSpeed.LOW:
                    _ceilingFan.Low();
                    break;
                case CeilingFan.FanSpeed.OFF:
                    _ceilingFan.Off();
                    break;
            }
        }
    }
}
