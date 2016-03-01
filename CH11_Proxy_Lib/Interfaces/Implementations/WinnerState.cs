using System;
using CH11_Proxy_Remote.Machines;

namespace CH11_Proxy_Remote.Interfaces.Implementations
{
    [Serializable()]
    public class WinnerState : State
    {
        [NonSerialized()]
         private GumballMachine _gbMachine;

         public WinnerState(GumballMachine gbMachine)
        {
            _gbMachine = gbMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we are already giving you a guball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turnning twice doesn't give you another gumball!");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");
            _gbMachine.ReleaseBall();
            bool outOfGumballs = false;

            if (_gbMachine.Count > 0)
            {
                _gbMachine.ReleaseBall();

                if (_gbMachine.Count > 0)
                    _gbMachine.State = _gbMachine.NoQuarterState;
                else
                    outOfGumballs = true;
            }
            else
                outOfGumballs = true;

            if(outOfGumballs)
            {
                Console.WriteLine("Oops, out of gumballs");
                _gbMachine.State = _gbMachine.SoldOutState;
            }

        }
    }
}