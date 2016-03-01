using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    class SimpleRemoteControl
    {
        public ICommand Slot { get; set; }

        public SimpleRemoteControl()
        {

        }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }

    }
}
