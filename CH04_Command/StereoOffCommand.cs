using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    class StereoOffCommand : ICommand
    {
        private Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        
        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}
