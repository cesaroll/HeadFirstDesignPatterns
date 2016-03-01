using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public class MacroCommand : ICommand
    {
        private ICommand[] _commands;

        public MacroCommand(params ICommand[] commands)
        {
            _commands = commands;
        }
        
        public void Execute()
        {
            foreach (ICommand command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (ICommand command in _commands)
            {
                command.Undo();
            }
        }
    }
}
