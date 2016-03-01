using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    public class RemoteControl
    {
        private const int SLOTS = 7;

        private NoCommand _noCommand;

        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[SLOTS];
            _offCommands = new ICommand[SLOTS];

            _noCommand = new NoCommand();

            for (int i = 0; i < SLOTS; i++)
            {
                _onCommands[i] = _noCommand;
                _offCommands[i] = _noCommand;
            }

            _undoCommand = _noCommand;

        }

        /// <summary>
        /// Set Command
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="onCommand"></param>
        /// <param name="offCommand"></param>
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            if (IsValidSlot(slot))
            {
                _onCommands[slot] = onCommand;
                _offCommands[slot] = offCommand;
            }
        }

        /// <summary>
        /// On Button Pushed
        /// </summary>
        /// <param name="slot"></param>
        public void OnButtonWasPushed(int slot)
        {
            if (IsValidSlot(slot))
            {
                _onCommands[slot].Execute();

                _undoCommand = _onCommands[slot];
            }
        }

        /// <summary>
        /// Off Button Pushed
        /// </summary>
        /// <param name="slot"></param>
        public void OffButtonWasPushed(int slot)
        {
            if (IsValidSlot(slot))
            {
                _offCommands[slot].Execute();

                _undoCommand = _offCommands[slot];
            }
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
            _undoCommand = _noCommand;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\n------ Remote Control ------\n");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.Append("[Slot ").Append(i).Append("] ");
                
                if(_onCommands[i] != null)
                    sb.Append(_onCommands[i].GetType().Name);
                
                sb.Append("   ");
                
                if(_offCommands[i] != null)
                    sb.Append(_offCommands[i].GetType().Name);
                
                sb.Append("\n");                
            }

            sb.Append("[Undo] ").Append(_undoCommand.GetType().Name).Append("\n");

            return sb.ToString();

        }

        private bool IsValidSlot(int slot)
        {
            return (slot >= 0 && slot < SLOTS);
        }


    }
}
