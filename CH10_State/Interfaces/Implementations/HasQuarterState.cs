using System;
using CH11_Proxy_Remote.Machines;

namespace CH11_Proxy_Remote.Interfaces.Implementations
{
    public class HasQuarterState : State
    {
        private GumballMachine _gbMachine;
        private Random _randomWinner;

        public HasQuarterState(GumballMachine gbMachine)
        {
            _gbMachine = gbMachine;
            _randomWinner = new Random();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gbMachine.State = _gbMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned ...");

            int winner = _randomWinner.Next(10);

            if (winner == 0 && _gbMachine.Count > 1)
            {
                _gbMachine.State = _gbMachine.WinnerState;
            }
            else
            {
                _gbMachine.State = _gbMachine.SoldState;    
            }

        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "Machine has quarter";
        }
    }
}