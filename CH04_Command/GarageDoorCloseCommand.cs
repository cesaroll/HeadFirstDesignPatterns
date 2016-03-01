using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public class GarageDoorCloseCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }
    }
}
