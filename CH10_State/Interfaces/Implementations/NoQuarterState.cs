using System;
using CH11_Proxy_Remote.Machines;

namespace CH11_Proxy_Remote.Interfaces.Implementations
{
    public class NoQuarterState : State
    {
        private GumballMachine _gbMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gbMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gbMachine.State = _gbMachine.HasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override string ToString()
        {
            return "Machine is waiting for quarter";
        }
    }
}