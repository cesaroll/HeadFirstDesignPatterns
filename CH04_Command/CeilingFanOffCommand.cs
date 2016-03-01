using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public class CeilingFanOffCommand : CeilingFanCommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan)
            : base(ceilingFan)
        {
        }
        protected override void ExecuteCommand()
        {
            _ceilingFan.Off();
        }
    }
}
